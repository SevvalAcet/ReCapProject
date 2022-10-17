using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,NorthwindContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from car in context.Cars //arabalarla marka ve renkleri birleştirdi
                             join brand in context.Brands on car.BrandId equals brand.BrandId //on kullanarak kural veriyoruz
                             join color in context.Colors on car.ColorId equals color.ColorId // car'daki colorId ile color'ın aId'si eşitse onları joinle
                             select new CarDetailDto
                             {
                                 BrandName = brand.BrandName,
                                 CarName = car.Description,
                                 ColorName = color.ColorName,
                                 DailyPrice = (int)car.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
