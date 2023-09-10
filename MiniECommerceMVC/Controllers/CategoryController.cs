using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MiniECommerceMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IProductService _productService;

        public CategoryController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var result = _productService.GetAllProduct();
            ViewBag.ListStatus = result.Message;
            return View(result.Data);
        }
    }
}
