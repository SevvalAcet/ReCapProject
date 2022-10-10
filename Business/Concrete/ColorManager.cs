using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new Result(true);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new Result(false);

        }

        public IResult Update(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
