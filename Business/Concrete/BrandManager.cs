using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (DataSetDateTime.Now.Hour == 22)
            {
                return new ErrorDataResult();
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),true,"Ürünler listelendi");
        }

        public Brand GetByBrandId(int brandId)
        {
            return _brandDal.Get(b => b.BrandId == brandId);
        }
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new Result(true, "marka eklendi");
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new Result(false,"marka silindi");
        }

        public IResult Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
