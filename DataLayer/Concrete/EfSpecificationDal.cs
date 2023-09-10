using CoreLayer.DataAccesses.Concrete;
using DataLayer.Abstract;
using DataLayer.Concrete.Context;
using EntityLayer.Concrete;

namespace DataLayer.Concrete
{
    public class EfSpecificationDal : EfEntityRepositoryBase<Specification, ECommerceContext>, ISpecificationDal
    {
    }
}