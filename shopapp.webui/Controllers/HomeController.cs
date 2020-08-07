using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Concrate;
using shopapp.data.Abstract;

namespace shopapp.webui.Controllers
{
    public class HomeController : Controller
    {   
        private IProductService _productService;

        public HomeController(IProductService productService)
        {//bu çağırıldığında dolu versiyonunu çağırmam gerek o yüzden startup içinde addscopedi kullanırım
            this._productService=productService;
        }
        public IActionResult Index()
        {         
        var productsViewModel = new ProductViewModel
        {
            Products = _productService.GetAll(),

        };
            return View(productsViewModel);
        }
        public IActionResult Abouth()
        {
            return View();
        }
         public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}