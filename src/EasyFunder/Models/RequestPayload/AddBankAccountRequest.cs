using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.RequestPayload
{
    public class AddBankAccountRequest
    {
        public string user_id { get; set; }
        public string bank_name { get; set; }
        public string account_number { get; set; }
        public string branch { get; set; }
        public string swift_code { get; set; }
        public string address { get; set; }
    }
}
