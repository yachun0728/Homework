using System.Linq;
using System.Web.Mvc;
using Homework.Enums;
using Homework.helper;
using Homework.Models;

namespace Homework.Controllers
{
    public class HomeController : Controller
    {
        private readonly EnumHelper _EnumHelper = new EnumHelper();

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

            var moneyList = skillTreeHomeworkEntities.AccountBook.Take(10).Select(a => new MoneyListDisplayModel()            {
                CategoryDispaly = a.Categoryyy,
                Money = a.Amounttt,
                Date = a.Dateee
            }).ToList();
            
            foreach (var mm in moneyList)
            {
                mm.Category = _EnumHelper.GetEnumDisplayName((Category) mm.CategoryDispaly);
                mm.Number = number;
                ++number;
            }
            //888
            return View(moneyList);
        }
    }
}