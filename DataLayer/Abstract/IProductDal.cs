using CoreLayer.DataAccesses.Abstract;
using EntityLayer;

namespace DataLayer.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}