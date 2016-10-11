using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.DataBaseTables
{
    public class UserInfo
    {
        public string id { get; set; }
        public string first_name { get; set; }
        public string second_name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string verification_code { get; set; }
        public bool verification_bool { get; set; }
        public bool has_bank_account { get; set; }
        public bool has_spending_categories { get; set; }
        public bool has_charities_to_donation { get; set; }
    }
}
