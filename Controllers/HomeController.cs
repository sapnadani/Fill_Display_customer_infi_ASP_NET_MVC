using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomePage1.Models;
namespace HomePage1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GotoHome()
        {
            /* Case where we are adding default value which can be displayed when this 
             * page is called */
            ViewData["CurrentTime"] = DateTime.Now.ToString();
            Customer objCustomer = new Customer();
            objCustomer.id = 1000;
            objCustomer.CustomerId = "1001";
            objCustomer.amount = 1500;
            return View(objCustomer);
        }
        public ActionResult FillCustomer()
        {
            return View();
        }
        [HttpPost]
        public ViewResult DisplayCustomer(Customer obj)
        {
            /* Case where we need input from the user and we are accessing HTML form
            Customer obj = new Customer();
            obj.id = Convert.ToInt16(Request.Form["CustomerId"]);
            obj.CustomerId = (Request.Form["CustomerCode"]);
            obj.amount = Convert.ToDouble(Request.Form["CustomerAmount"]);
             */
            /* Case for Unit testing 
            obj.id = 101;
            obj.CustomerId = "c001";
            obj.amount = 500;
            return View("DisplayCustomer",obj);
             */ 
            return View(obj);
        }
	}
}