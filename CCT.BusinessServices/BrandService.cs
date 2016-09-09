using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCT.BusinessEntities.Model;
using CCT.DataModel.UnitOfWork;
using AutoMapper;
using CCT.DataModel;
using System.Transactions;

namespace CCT.BusinessServices
{
    public class BrandService : IBrandService
    {
        private readonly UnitOfWork _unitOfWork;

        public BrandService()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int CreateBrand(BrandEntity brandEntity)
        {
            using (var scope = new TransactionScope())
            {
                var brand = new Brand
                {
                    BrandName = brandEntity.BrandName
                };

                _unitOfWork.BrandRepository.Insert(brand);
                _unitOfWork.Save();

                scope.Complete();
                return brand.BrandId;
            }
        }

        public bool DeleteBrand(int entityId)
        {
            var success = false;
            if (entityId > 0)
            {
                using (var scope = new TransactionScope())
                {
                    var brand = _unitOfWork.BrandRepository.GetByID(entityId);
                    if (brand != null)
                    {

                        _unitOfWork.BrandRepository.Delete(brand);
                        _unitOfWork.Save();
                        scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }

        public IEnumerable<BrandEntity> GetAllBrands()
        {
            var brands = _unitOfWork.BrandRepository.GetAll().ToList();
            if (brands.Any())
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Brand, BrandEntity>());
                var mapper = config.CreateMapper();

                var brandModel = mapper.Map<List<Brand>, List<BrandEntity>>(brands);
                return brandModel;
            }
            return null;
        }

        public BrandEntity GetBrandById(int entityId)
        {
            var product = _unitOfWork.BrandRepository.GetByID(entityId);
            if (product != null)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Brand, BrandEntity>());
                var mapper = config.CreateMapper();

                var productModel = mapper.Map<Brand, BrandEntity>(product);
                return productModel;
            }
            return null;
        }

        public bool UpdateBrand(int entityId, BrandEntity brandEntity)
        {
            var success = false;
            if (brandEntity != null)
            {
                using (var scope = new TransactionScope())
                {
                    var brand = _unitOfWork.BrandRepository.GetByID(entityId);
                    if (brand != null)
                    {
                        brand.BrandName = brandEntity.BrandName;

                        _unitOfWork.BrandRepository.Update(brand);
                        _unitOfWork.Save();

                        scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }
    }
}
