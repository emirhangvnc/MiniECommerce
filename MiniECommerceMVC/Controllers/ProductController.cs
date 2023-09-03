﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MiniECommerceMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
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
