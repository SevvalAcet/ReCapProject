using Core.Entities;

namespace Entities.DTOs
{
    //Bu bir veri tabanı tablosu olmadığı için IEntity vermiyoruz .(birden fazla tablonun joini)
    public class CarDetailDto:IDto
    {
        public string CarName { get; set; }
        public int DailyPrice { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }

    }
}
