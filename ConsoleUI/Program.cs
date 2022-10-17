using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CarTest();
            // BrandTest();
            // CustomerTest();
            // UserTest();

        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAll();
            foreach (var user in result.Data)
            {
                Console.WriteLine(user.FirstName);
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetAll();
            foreach (var customer in result.Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car1 = new Car { BrandId = 11, CarName = "test", ColorId = 11, DailyPrice = 1, Description = "den", ModelYear = 11 };
            var result = carManager.Add(car1);
            Console.WriteLine(result.IsSuccess + " " + result);


            //foreach (var car in carManager.GetAll().Data)
            //{
            //    Console.WriteLine("{0}", car.CarName);
            //}

            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine("{0}, {1}, {2}, {3}, ", car.CarName,car.Brandname,car.ColorName,car.DailyPrice);
            //}
        }
    }
}