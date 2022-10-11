using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

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
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaitenceTime);
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),Messages.ProductsListed);
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
