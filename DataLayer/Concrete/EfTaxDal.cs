﻿using CoreLayer.DataAccesses.Concrete;
using DataLayer.Abstract;
using DataLayer.Concrete.Context;
using EntityLayer;

namespace DataLayer.Concrete
{
    public class EfTaxDal : EfEntityRepositoryBase<Tax, ECommerceContext>, ITaxDal
    {
    }
}