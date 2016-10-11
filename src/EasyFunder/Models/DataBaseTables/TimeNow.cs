using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.DataBaseTables
{
    public class TimeNow
    {
        public string id { get; set; }
        public string day { get; set; }
        public string month { get; set; }
        public string year { get; set; }
        public string seconds { get; set; }
        public string minutes { get; set; }
        public string hours { get; set; }
    }
}
