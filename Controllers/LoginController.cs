using Horizon_HR.Dtos.Login;
using Horizon_HR.Repositories.Implementations;
using Horizon_HR.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Horizon_HR.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class LoginController : ControllerBase
    {

        private readonly HttpClient _httpClient;
        private readonly IUserRepository _userRepository;

        public LoginController(HttpClient httpClient, IUserRepository userRepository)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://20.199.23.144:8080");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _userRepository = userRepository;

        }
        /// <summary>
        /// Authenticate a user.
        /// </summary>
        /// <param name="loginDto">The data transfer object containing user credentials.</param>
        /// <returns>An object containing the neccessary tokens.</returns>
        /// 
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var payload = new
            {
                appSource = GlobalVariables.AppSource,
                username = loginDto.Username,
                password = loginDto.Password,
            };

            var jsonPayload = JsonSerializer.Serialize(payload);
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("/api/Account/Login", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    };

                    var result = JsonSerializer.Deserialize<ExternalApiResponse>(responseString, options);
                    var token = result.Token;
                    var handler = new JwtSecurityTokenHandler();
                    var decodedToken = handler.ReadJwtToken(token);
                    
                    var userIdAsString = decodedToken.Claims.First(c => c.Type == "userId").Value;
                    Guid userId = Guid.Parse(userIdAsString);
                    var userData = await _userRepository.GetUserByIdAsync(userId);
                    
                    if (userData == null)
                        throw new Exception("User not found");


                    return Ok(new
                    {
                        message = "User logged in successfully.",
                        data = new
                        {
                            status = 200,
                            user = userData,
                            refreshToken = result.RefreshToken,
                            expiration = result.Expiration
                        }
                    } 
                        );

            }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();

                    return Unauthorized(new {status = 401, message = error});
                }
        }
    }
}
