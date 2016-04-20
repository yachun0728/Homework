using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using Homework.Enums;
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
            var skillTreeHomeworkEntities = new SkillTreeHomeworkEntities();
            int number = 1;

            var moneyList = skillTreeHomeworkEntities.AccountBook.Take(10).Select(a => new MoneyList()
            {
                CategoryEnum = (Category)a.Categoryyy,
                Money = a.Amounttt,
                Date = a.Dateee
            }).ToList();
            
            foreach (var mm in moneyList)
            {
                mm.Category = GetEnumDescription(mm.CategoryEnum);
                mm.Number = number;
                ++number;
            }
            //888
            return View(moneyList);
        }

        private string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;

            return value.ToString();
        }
    }
}