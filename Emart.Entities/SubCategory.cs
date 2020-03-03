using System;
using System.Collections.Generic;
using System.Text;

namespace EMart.Entities
{
    public class SubCategory
    {
        public virtual int SubCategoryId { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual string SubCategoryName { get; set; }

    }
}
