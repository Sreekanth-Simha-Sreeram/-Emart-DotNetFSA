using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.Entities
{
    public class IStock
    {
        public List<Products> ProductList { get; set; }
        public List<Stock> StockList { get; set; }

    }
}
