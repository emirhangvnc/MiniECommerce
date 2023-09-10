﻿using CoreLayer.DataAccesses.Abstract;
using EntityLayer.Concrete;

namespace DataLayer.Abstract
{
    public interface IProductAndSpecificationDal : IEntityRepository<ProductAndSpecification>
    {
    }
}