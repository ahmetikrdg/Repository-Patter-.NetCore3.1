using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using shopapp.entity;

namespace shopapp.webui.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult list(int? id,string q)
        { 
           // Console.WriteLine(q);
            //Console.WriteLine(HttpContext.Request.Query["q"].ToString()); -- iki türlüde searc sonucunu alırsın
            /* var products=ProductRepository.Products;//tüm ürünleri getirir
            if(id!=null)
            {
                products=products.Where(p=>p.CategoryId==id).ToList();//kategoriye tıklarsan kategori ile eşleşen ürünleri getirir
            }
        
           if (!string.IsNullOrEmpty(q))
           {
                products = products.Where(i=>i.Name.Contains(q)).ToList();//searcha yazarsan liste gidip arar
           }
           var productsViewModel = new ProductViewModel//sonrada bunları paketler productsviewe gönderir
           {
            Products =products
           };
            return View(productsViewModel); */
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id) //inceleye bastım bastığım productid getprouctbyideye gider ve vtdeki id ile eşleşir
        {
            return View();
        }
        [HttpGet] //gelir
        public IActionResult Create(){
           // ViewBag.Categories = new SelectList(CategoryRepository.Categories,"CategoryId","Name");//kategorinin adı ve idsi gitsin crete ve edite gider orada açıklaması var
            return View(new Product());
        }
        [HttpPost] //gönderir
        public IActionResult Create(Product p)
        { 
            // if(ModelState.IsValid)//beklediğimiz bütün bilgiler kurallara göre oluşturulmuş
            // {
            //    ProductRepository.AddProduct(p);
            //    return RedirectToAction("list");  //doğruysa bunlar
            // }   
            // else//değilse herhangi bir problem vardır
            // {  
            //     ViewBag.Categories = new SelectList(CategoryRepository.Categories,"CategoryId","Name");
            //     return View(p);//yanlşsa geldiği create sayfasına geri gönderirim ve bilgileride oraya gönderirim
            // }       
            return ViewBag();
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
           // ViewBag.Categories = new SelectList(CategoryRepository.Categories,"CategoryId","Name");
            return View();//bir product gönderir oda editin üzerine tek tek gelir bilgiler
        }

        [HttpPost]
        public IActionResult Edit(Product p)
        {
           // ProductRepository.EditProduct(p);
            return RedirectToAction("list");

        }

        [HttpPost]
        public IActionResult Delete(int ProductId)//productId adı cshtmldekiyle aynı olmak zorundaydı ve oldu
        {
           // ProductRepository.DeleteProduct(ProductId);
            return RedirectToAction("list");
        }



    }
}