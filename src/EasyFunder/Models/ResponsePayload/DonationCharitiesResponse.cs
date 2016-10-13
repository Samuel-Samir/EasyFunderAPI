using EasyFunder.Models.DataBaseTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.ResponsePayload
{
    public class DonationCharitiesResponse
    {
        public string hasCharities { get; set; }
        public List<CharityInfo> donationCharities { get; set; } = new List<CharityInfo>();

    }
}
