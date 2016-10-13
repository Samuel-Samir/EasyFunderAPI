using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.RequestPayload
{
    public class AddSpendingCategoriesRequest
    {
        public List<AddSpendingCategoriesInf> SpendingCategories { get; set; } = new List<AddSpendingCategoriesInf>();
    }
}
