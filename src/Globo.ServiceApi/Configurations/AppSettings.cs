using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globo.ServiceApi.Configurations
{
    public class AppSettings
    {
        public string[] CDEGroups { get; set; }
        public string[] VeiculosGroups { get; set; }
        public string Query { get; set; }
        public string QueryTwo { get; set; }
        public string QueryThree { get; set; }
        public string testar { get; set; }
        public string ResourceColumnCDE { get; set; }
        public string UserLoginPassword { get; set; }
        public string DefaultURl { get; set; }
    }
}
