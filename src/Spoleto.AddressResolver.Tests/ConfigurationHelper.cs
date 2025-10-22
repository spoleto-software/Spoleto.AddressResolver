using Microsoft.Extensions.Configuration;
using Spoleto.AddressResolver.Dadata;

namespace Spoleto.AddressResolver.Tests
{
    internal static class ConfigurationHelper
    {
        private static readonly IConfigurationRoot _config;

        static ConfigurationHelper()
        {
            _config = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true)
               .AddUserSecrets("4b85f299-ff1b-4b4e-9464-c492fc77a261")
               .Build();
        }

        public static IConfigurationRoot Configuration => _config;

        public static DadataOptions GetDadataOptions()
        {
            var options = _config.GetSection(nameof(DadataOptions)).Get<DadataOptions>()!;

            return options;
        }
    }
}
