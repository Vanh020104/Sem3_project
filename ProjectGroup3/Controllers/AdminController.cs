using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectGroup3.Controllers
{
    public class AdminController : Controller
    {
        // GET: /<controller>/
        public IActionResult order()
        {
            return View("OrderManagement/order");
        }
        public IActionResult customer() 
        {
            return View("CustomerManagement/customer");
        }
        public IActionResult product()
        {
            return View("ProductManagement/product");
        }

        public IActionResult addProduct()
        {
            return View("ProductManagement/addProduct");
        }
        public IActionResult editProduct()
        {
            return View("ProductManagement/editProduct");
        }
    }
}

