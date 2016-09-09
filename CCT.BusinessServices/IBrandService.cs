using CCT.BusinessEntities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCT.BusinessServices
{
    public interface IBrandService
    {
        BrandEntity GetBrandById(int entityId);
        IEnumerable<BrandEntity> GetAllBrands();
        int CreateBrand(BrandEntity productEntity);
        bool UpdateBrand(int entityId, BrandEntity productEntity);
        bool DeleteBrand(int entityId);
    }
}
