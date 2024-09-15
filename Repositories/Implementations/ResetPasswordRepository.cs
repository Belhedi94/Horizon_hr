using AutoMapper;
using Azure;
using Horizon_HR.Dtos.ResetPassword;
using Horizon_HR.Repositories.Interfaces;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Horizon_HR.Repositories.Implementations
{
    public class ResetPasswordRepository : IResetPasswordRepository
    {
        private readonly IMapper _mapper;
        private readonly ILogger<ResetPasswordRepository> _logger;

        public ResetPasswordRepository(IMapper mapper,
            ILogger<ResetPasswordRepository> logger)
        {
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<bool> ResetPassword(RequestResetPasswordDto requestResetPasswordDto)
        {
            var payload = new
            {
                username = requestResetPasswordDto.Username,
                newPassword = requestResetPasswordDto.NewPassword,
                appSource = GlobalVariables.AppSource,
            };

            var jsonPayload = JsonSerializer.Serialize(payload);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://20.199.23.144:8080");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                try
                {
                    var response = await client.PostAsync("/api/Account/ResetPassword", content);
                    if (response.IsSuccessStatusCode)
                        return true;

                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Error response of resetting passwird", errorContent);
                    return false;


                } catch(Exception ex)
                {
                    
                    Console.WriteLine("Exception: ",  ex.Message);
                    return false;
                }
                

            }
        }
    }
}
