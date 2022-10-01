using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
               System.Console.WriteLine(car.ModelYear);
            }
        }
    }
}
