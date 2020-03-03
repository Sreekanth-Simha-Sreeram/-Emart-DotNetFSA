using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EMart.Tests.Exceptions
{
    class ProductNotFoundException : Exception
    {
       public string Messages= "Product Not found in stock";
        
        public ProductNotFoundException(string message)
        {
            this.Messages = message;
        }

    }
}
