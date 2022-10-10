using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);
    }
}
