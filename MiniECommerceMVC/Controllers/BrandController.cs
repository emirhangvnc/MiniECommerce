using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MiniECommerceMVC.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        public IActionResult Index()
        {
            var result = _brandService.GetAllBrand();
            ViewBag.ListStatus= result.Message;
            return View(result.Data);
        }
    }
}
