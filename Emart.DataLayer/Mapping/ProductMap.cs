using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EMart.Entities;

namespace EMart.BusinessLayer
{
    public class ProductMap : ClassMap<Products>
    {
        public ProductMap()
        {
            Id(x => x.Id);

            Map(x => x.ProductName);

            Map(x => x.SubCategoryId);
            Map(x => x.Price);
            Map(x => x.BuyerId);
            Map(x => x.CategoryId);
            Table("product");

        }
    }


}
