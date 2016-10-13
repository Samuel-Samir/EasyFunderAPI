using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.ResponsePayload
{
    public class getCharitiesResponse
    {
        public List<Charities> CharitiesList { get; set; } = new List<Charities>(); 

    }
}
