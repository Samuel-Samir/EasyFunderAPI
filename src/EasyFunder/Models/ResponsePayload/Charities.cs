using EasyFunder.Models.DataBaseTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.ResponsePayload
{
    public class Charities
    {
        public string categoryName { get; set; }
        public int numberOfCharities { get; set; }
        public int numberOfPages { get; set; }
        public List<CharityInfo> charityDetails { get; set; } = new List<CharityInfo>();

    }
}
