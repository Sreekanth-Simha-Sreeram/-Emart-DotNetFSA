using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.Entities
{
    public class Buyer
    {
        public int BuyerId { get; set; }
        public string BuyerName { get; set; }
        public  string Email { get; set; }
        public string  Password { get; set; }
        public long MobileNumber { get; set; }
        public DateTime CreatedDatetime { get; set; }
    }
}
