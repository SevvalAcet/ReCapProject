using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if(car.Description.Length >=2 && car.DailyPrice>0)
            {
               return new ErrorResult ("Ürün ismi min 2 karakter olmalıdır")
            }
            _carDal.Add(car);
           return new SuccessResult("Ürün eklendi")
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new Result(false);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();

        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsBrandId(int brandId)
        {
            return _carDal.GetAll(c=>c.BrandId== brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
