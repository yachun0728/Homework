using System;
using System.Linq;
using System.Web.Mvc;
using Homework.Enums;
using Homework.helper;
using Homework.Models;

namespace Homework.Controllers
{
    [Authorize]
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

        //[Authorize(Users = "vip@test.com")]
        public ActionResult EditButton()
        {
            return View();
        }
        
        public ActionResult List()
        {
            var skillTreeHomeworkEntities = new SkillTreeHomeworkEntities1();
            int number = 1;

            var moneyList = skillTreeHomeworkEntities.AccountBooks.OrderByDescending(a => a.Dateee).Take(10).Select(a => new MoneyListDisplayModel()            {
                CategoryDisplay = a.Categoryyy,
                Money = a.Amounttt,
                Date = a.Dateee
            }).ToList();
            
            foreach (var mm in moneyList)
            {
                mm.Category = _EnumHelper.GetEnumDisplayName((Category) mm.CategoryDisplay);
                mm.Number = number;
                ++number;
            }
            //888
            return View(moneyList);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Category, Money, Date, Description")] MoneyList moneyList)
        {
            if (ModelState.IsValid)
            {
                var skillTreeHomeworkEntities = new SkillTreeHomeworkEntities1();
                skillTreeHomeworkEntities.AccountBooks.Add(new AccountBook()
                {
                    Id = Guid.NewGuid(),
                    Categoryyy = Int32.Parse(moneyList.Category),
                    Amounttt = (int)moneyList.Money,
                    Dateee = moneyList.Date,
                    Remarkkk = moneyList.Description
                });
                skillTreeHomeworkEntities.SaveChanges();

            }
            return RedirectToAction("Index");
        }
    }
}