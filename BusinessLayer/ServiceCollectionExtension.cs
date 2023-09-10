using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataLayer.Abstract;
using DataLayer.Concrete;
using DataLayer.Concrete.Context;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection services)
        {

            services.AddScoped<IBrandService, BrandManager>();
            services.AddScoped<IBrandDal, EfBrandDal>();

            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<IMenuDal, EfMenuDal>();

            services.AddScoped<IProductAndCategoryDal, EfProductAndCategoryDal>();

            services.AddScoped<IProductAndImageDal, EfProductAndImageDal>();

            services.AddScoped<IProductAndSpecificationDal, EfProductAndSpecificationDal>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();

            services.AddScoped<ISpecificationDal, EfSpecificationDal>();

            services.AddScoped<ISpecificationValueDal, EfSpecificationValueDal>();

            services.AddScoped<ITaxDal, EfTaxDal>();

            services.AddScoped<ECommerceContext>();

            return services;

        }
    }
}