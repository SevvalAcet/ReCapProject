using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);
    }
}
