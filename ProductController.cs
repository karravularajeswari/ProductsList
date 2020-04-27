using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPractice.Models;

namespace MVCPractice.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ProductData pd = new ProductData();
        public ViewResult Index()
        {
            return View(pd.GetProducts);
        }
        public ViewResult Details(int id)
        {
            return View(pd.GetProducts.Single(x=>x.Pid==id));
        }
    }
}