using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color color);
        void Remove(Color color);
        Color Get(Color color);
        void Update(Color color);
    }
}
