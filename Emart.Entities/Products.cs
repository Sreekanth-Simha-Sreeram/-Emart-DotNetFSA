using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.Entities
{
    public class Products
    {
        public virtual int Id { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string CategoryId { get; set; }
        public virtual string SubCategoryId { get; set; }
        public virtual int Price { get; set; }
        public virtual int BuyerId { get; set; }

    }
}

