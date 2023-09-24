using CoreLayer.Results;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ITaxService
    {
        IDataResult<Tax> GetByTaxId(int id);
    }
}
