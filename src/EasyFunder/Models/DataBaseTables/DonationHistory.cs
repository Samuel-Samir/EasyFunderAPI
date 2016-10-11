using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFunder.Models.DataBaseTables
{
    public class DonationHistory
    {
        public string id { get; set; }
        public string user_id { get; set; }
        public List<string> list_donation_charities { get; set; } = new List<string>();
        public List<string> spending_categories { get; set; } = new List<string>();
        public List<string> amount_of_money_from_each_category { get; set; } = new List<string>();
        public string total_donation { get; set; }
        public string month_of_donation { get; set; }
        public bool is_read { get; set; }
        public string year_of_donation { get; set; }
    }
}
