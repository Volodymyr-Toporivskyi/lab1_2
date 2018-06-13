using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab1_2.Models;
namespace lab1_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Calculator am, String calc)
        {

            switch (calc)
            {
                case "Add":
                    am.result = am.firstNum + am.secondNum;
                    break;
                case "Sub":
                    am.result = am.firstNum - am.secondNum;
                    break;
                case "Mult":
                    am.result = am.firstNum * am.secondNum;
                    break;
                case "Div":
                    am.result = am.firstNum / am.secondNum;
                    break;
            }
            return View(am);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}