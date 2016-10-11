using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.DataBaseTables
{
    public class CharityInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string rate { get; set; }
        public string idcountry { get; set; }
        public string country { get; set; }
        public string total_revenue { get; set; }
        public string programs_expenses { get; set; }
        public string fundraising_expenses { get; set; }
        public string total_functional_expenses { get; set; }
        public string category_name { get; set; }
    }
}
