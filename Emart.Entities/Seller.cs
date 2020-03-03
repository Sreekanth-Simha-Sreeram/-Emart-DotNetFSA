using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.Entities
{
    public class Seller
    {
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long MobileNumber { get; set; }
        public string CompanyName { get; set; }
        public string PostelAdress { get; set; }
        public string GSTIN { get; set; }
        public string BankDetails { get; set; }
    }
}
