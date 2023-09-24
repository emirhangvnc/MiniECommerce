using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;

namespace MiniECommerceMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index(string url)
        {
            var result = _productService.ProducDetailByUrl(url);

            return View(result.Data);
        }
        public IActionResult Index2()
        {
            return View();
        }
    }
}
