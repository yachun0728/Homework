using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Homework.Models;

namespace Homework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult List()
        {
            var moneyList = new List<MoneyList>();
            moneyList.Add(new MoneyList()
            {
                Category="支出",
                Money=(decimal)1000,
                Date=DateTime.Now.Date,
                Description = "買書"
            });

            moneyList.Add(new MoneyList()
            {
                Category = "支出",
                Money = (decimal)1500,
                Date = DateTime.Now.Date,
                Description = "買文具"
            });

            moneyList.Add(new MoneyList()
            {
                Category = "收入",
                Money = (decimal)300,
                Date = DateTime.Now.Date,
                Description = "賣筆"
            });
            //888
            return View(moneyList);
        }
    }
}