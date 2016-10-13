using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.ResponsePayload
{
    public class GetCategoryCharitiesResponse
    {
        public bool status { get; set; }
        public string categoryName { get; set; }
        public List<CharitiesPaging> charitiesAll { get; set; } = new List<CharitiesPaging>();

    }
}
