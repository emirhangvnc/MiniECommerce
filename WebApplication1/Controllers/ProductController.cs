using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetProductsByCategoryId(int categoryId)
        {
            var result = _productService.GetProductsByCategoryId(categoryId);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetByProductId(int productId)
        {
            var result = _productService.GetByProductId(productId);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAllProduct()
        {
            var result = _productService.GetAllProduct();
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
