using BusinessLayer.Abstract;
using BusinessLayer.Concrete.Base;
using CoreLayer.Results;
using DataLayer.Abstract;
using DataLayer.Concrete.Context;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class TaxManager : ManagerBase, ITaxService
    {
        ITaxDal _taxDal;
        public TaxManager(ECommerceContext eCommerceContext, ITaxDal taxDal) : base(eCommerceContext)
        {
            _taxDal = taxDal;
        }

        public IDataResult<Tax> GetByTaxId(int id)
        {
            var result = _taxDal.Get(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<Tax>("Bu Vergi bulunamadı");
            return new SuccessDataResult<Tax>(result);
        }
    }
}
