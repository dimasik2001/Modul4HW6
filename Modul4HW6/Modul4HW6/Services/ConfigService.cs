using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul4HW6.Services.Absractions;
using Newtonsoft.Json;

namespace Modul4HW6.Services
{
    public class ConfigService : IConfigService
    {
        private const string _path = "config.json";
        private Config _config;
        public ConfigService()
        {
            Init();
        }

        public string ConnectionString => _config.ConnectionString;

        private void Init()
        {
            _config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(_path));
        }
    }
}
