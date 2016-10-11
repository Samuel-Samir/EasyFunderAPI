using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.DataBaseTables
{
    public class UserDonationCharity
    {

        public string id { get; set; }
        public string user_id { get; set; }
        public string charity_id { get; set; }
    }
}
