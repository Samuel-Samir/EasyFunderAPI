using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.DataBaseTables
{
    public class UserSpendingCategories
    {
        public string id { get; set; }
        public string user_id { get; set; }
        public string spending_category_name { get; set; }
        public double donation_Percentage { get; set; }
    }
}
