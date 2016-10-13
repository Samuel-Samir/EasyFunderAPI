using EasyFunder.Models.DataBaseTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.ResponsePayload
{
    public class SignupResponse
    {
        public bool uniqueEmail { get; set; }

        public UserInfo user { get; set; } = new UserInfo();

    }
}
