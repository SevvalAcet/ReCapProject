using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;
using System.Net.Http.Headers;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        private Car? carToDelete;

        public InMemoryCarDal()
        {
            _cars = new List<Car>();
            {
                new Car { Id = 1, BrandId = 1, ColorId = 2, DailyPrice = 2000, Descripton = "2001 model bmw", ModelYear = 2001 };
            }
        }
        public List<Car> GetAll()
        {
           return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Add(Car car)
        {
          _cars.Add(car);
        }

        public void Delete(Car car)
        {
         Car carToDelete = _cars.SingleOrDefault(C => C.Id == car.Id);

         _cars.Remove(carToDelete);
         }

         public void Update(Car car)
         {
            Car carToUpdate = _cars.SingleOrDefault(C => C.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descripton = car.Descripton;
         }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
    }
