using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.RequestPayload
{
    public class AddSpendingCategoriesInf
    {
        public string user_id { get; set; }
        public string spending_category_name { get; set; }
        public double donation_Percentage { get; set; }
    }
}
