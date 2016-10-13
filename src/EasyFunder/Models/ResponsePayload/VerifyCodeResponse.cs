using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.ResponsePayload
{
    public class VerifyCodeResponse
    {
        public bool status { get; set; }
        public bool verificationCode { get; set; }

    }
}
