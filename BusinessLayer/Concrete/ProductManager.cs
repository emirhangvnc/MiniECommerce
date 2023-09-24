using BusinessLayer.Abstract;
using BusinessLayer.Concrete.Base;
using CoreLayer.Results;
using DataLayer.Abstract;
using DataLayer.Concrete.Context;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProductDto;

namespace BusinessLayer.Concrete
{
    public class ProductManager : ManagerBase, IProductService
    {
        IProductDal _productDal;
        IProductAndCategoryService _productAndCategoryService;
        ICategoryService _categoryService;
        IBrandService _brandService;
        ITaxService _taxService;
        public ProductManager(ECommerceContext eCommerceContext,
            IProductDal productDal, ICategoryService categoryService,
            IProductAndCategoryService productAndCategoryService,
            IBrandService brandService, ITaxService taxService) : base(eCommerceContext)
        {
            _productDal = productDal;
            _brandService = brandService;
            _taxService = taxService;
            _categoryService = categoryService;
            _productAndCategoryService = productAndCategoryService;
        }
        public IDataResult<List<Product>> GetAllProduct()
        {
            var result = _productDal.GetAll();
            if (result == null)
                return new ErrorDataResult<List<Product>>("Ürün Bulunamadı");
            return new SuccessDataResult<List<Product>>(result, "Ürünler Listelendi");
        }

        public IDataResult<List<ProductCategoryDetailsDto>> GetProductsByCategoryId(int categoryId)
        {
            var categoryCheck = _categoryService.GetByCategoryId(categoryId);
            if (categoryCheck == null)
                return new ErrorDataResult<List<ProductCategoryDetailsDto>>(categoryCheck.Message);

            var productAndCategory = _productAndCategoryService.GetByCategoryId(categoryId);

            var products = new List<ProductCategoryDetailsDto>();

            foreach (var item in productAndCategory.Data)
            {
                var product = GetByProductId(item.ProductId);
                var brandName = _brandService.GetByBrandId(product.Data.BrandId).Data.BrandName.ToString();

                var proefd = new ProductCategoryDetailsDto()
                {
                    ProductName = product.Data.ProductName,
                    ProductDescription = product.Data.ProductDescription,
                    Price = product.Data.Price,
                    ListPrice = product.Data.ListPrice,
                    StockQuantity = product.Data.StockQuantity,
                    BrandName = brandName,
                    Url = product.Data.Url == null? "#": product.Data.Url
                };

                products.Add(proefd);
            }

            if (products == null)
                return new ErrorDataResult<List<ProductCategoryDetailsDto>>("Bu Kategoride Ürün Bulunamadı");

            return new SuccessDataResult<List<ProductCategoryDetailsDto>>(products);
        }

        public IDataResult<ProductDetailsDto> ProducDetailByUrl(string url)
        {
            var productCheck = _productDal.Get(c => c.Url == url);
            if (productCheck == null)
                return new ErrorDataResult<ProductDetailsDto>("Ürün Bulunamadı");

            var brandName = _brandService.GetByBrandId(productCheck.BrandId).Data.BrandName.ToString();
            var taxValue = _taxService.GetByTaxId(productCheck.TaxId).Data.TaxValue;

            var products = new ProductDetailsDto()
            {
                ProductName = productCheck.ProductName,
                ProductDescription = productCheck.ProductDescription,
                Price = productCheck.Price,
                ListPrice = productCheck.ListPrice,
                StockQuantity = productCheck.StockQuantity,
                BrandName = brandName,
                TaxValue = taxValue
            };

            if (products == null)
                return new ErrorDataResult<ProductDetailsDto>("Bu Ürün Bulunamadı");

            return new SuccessDataResult<ProductDetailsDto>(products,"Ürün Listelendi");
        }

        public IDataResult<Product> GetByProductId(int id)
        {
            var result = _productDal.Get(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<Product>("Bu Id'de Ürün bulunamadı");
            return new SuccessDataResult<Product>(result);
        }
    }
}
