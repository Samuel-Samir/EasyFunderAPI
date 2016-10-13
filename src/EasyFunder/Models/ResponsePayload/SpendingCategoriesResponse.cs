using EasyFunder.Models.DataBaseTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.ResponsePayload
{
    public class SpendingCategoriesResponse
    {
        public string hasSpendingCategories { get; set; }
        public List<UserSpendingCategories> spendingCategories { get; set; } = new List<UserSpendingCategories>();

    }
}
