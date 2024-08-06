namespace Horizon_HR.Repositories.Implementations
{
    public class ExternalApiResponse
    {
        public string Status { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Expiration { get; set; }
    }
}