using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fschool.Models;

namespace fschool.Controllers
{
    public class ProductController : Controller
    {
        List<ProductModel> Products = new List<ProductModel>();
        public IActionResult Add()
        {
            return View("AddProduct",Products);
        }
       public IActionResult submit(ProductModel obj)
        {
            Products.Add(obj);
            return RedirectToAction("Add","Product");
        }
       
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}