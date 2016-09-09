using CCT.BusinessEntities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCT.BusinessServices
{
    public interface IProductService
    {
        ProductEntity GetProductById(int entityId);
        IEnumerable<ProductEntity> GetAllProducts();
        int CreateProduct(ProductEntity productEntity);
        bool UpdateProduct(int entityId, ProductEntity productEntity);
        bool DeleteProduct(int entityId);

    }
}
