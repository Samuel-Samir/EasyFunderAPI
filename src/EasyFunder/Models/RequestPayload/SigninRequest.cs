using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.RequestPayload
{
    public class SigninRequest
    {
        public string email { get; set; }
        public string Password { get; set; }
    }
}
