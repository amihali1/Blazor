namespace BlazorEmployeeEF.Data
{
    // Basic service to get configuration settings from appsettings.json
    public class AppSettingsService
    {
        private readonly IConfiguration _configuration;
        public AppSettingsService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetBaseUrl()
        {
            return _configuration.GetValue<string>("Settings").ToString();
        }
    }
}
