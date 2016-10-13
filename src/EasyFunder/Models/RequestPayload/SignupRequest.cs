using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.RequestPayload
{
    public class SignupRequest
    {
        public string first_name { get; set; }
        public string second_name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string Password { get; set; }
    }
}
