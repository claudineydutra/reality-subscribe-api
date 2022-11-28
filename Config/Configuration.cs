using Newtonsoft.Json;
using System.Reflection;

namespace Config
{
    public class Configuration
    {
        public const string Service = "Reality";
        public List<Service> Services { get; set; }
        public static Service GetService(string serviceName)
        {
            var settings = LoadJson();
            return settings.Services.FirstOrDefault(x => x.ServiceName == serviceName);
        }

        private static Configuration LoadJson()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var configPath = Path.Combine(path, "appsettings.json");
            var reader = new JsonTextReader(new StringReader(File.ReadAllText(configPath)));
            var serializer = new JsonSerializer();
            var config = serializer.Deserialize<Configuration>(reader);
            return config;

        }
    }

    public class Service
    {
        public string ServiceName { get; set; }
        public string ConnectionString { get; set; }
    }
}
