using Core.Entities;

namespace Entities.Concrete
{
    public class Rental:IEntity
    {
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string RentDate { get; set; }
        public string ReturnDate { get; set; }
    }
}
