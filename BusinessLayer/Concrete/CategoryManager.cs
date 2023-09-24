using BusinessLayer.Abstract;
using BusinessLayer.Concrete.Base;
using CoreLayer.Results;
using DataLayer.Abstract;
using DataLayer.Concrete.Context;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ManagerBase, ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ECommerceContext eCommerceContext, ICategoryDal categoryDal) : base(eCommerceContext)
        {
            _categoryDal = categoryDal;
        }
        public IDataResult<List<Category>> GetAllCategory()
        {
            var result = _categoryDal.GetAll();
            if (result == null)
                return new ErrorDataResult<List<Category>>("Kategory Bulunamadı");
            return new SuccessDataResult<List<Category>>(result, "Kategoriler Listelendi");
        }

        public IDataResult<Category> GetByCategoryId(int id)
        {
            var result = _categoryDal.Get(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<Category>("Bu Id'de Kategori bulunamadı");

            return new SuccessDataResult<Category>(result);
        }
    }
}
