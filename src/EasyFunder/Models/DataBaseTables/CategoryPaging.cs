using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.DataBaseTables
{
    public class CategoryPaging
    {
        public string id { get; set; }
		
        public List<string> charity_id { get; set; } = new List<string>();
        public List<string> charity_name { get; set; } = new List<string>();
        public string page_number { get; set; }
        public string category_name { get; set; }
    }
}
