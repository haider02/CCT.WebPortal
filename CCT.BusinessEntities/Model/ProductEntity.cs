using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCT.BusinessEntities.Model
{
    public class ProductEntity
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public int ProductCategoryId { get; set; }
        public int BrandId { get; set; }
    }
}
