using DataLayer.Concrete.Context;

namespace BusinessLayer.Concrete.Base
{
    public class ManagerBase
    {
        public ECommerceContext _eCommerceContext { get; }

        public ManagerBase(ECommerceContext eCommerceContext)
        {
            _eCommerceContext = eCommerceContext;
        }
    }
}