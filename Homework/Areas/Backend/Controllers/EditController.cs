using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Homework.Areas.Backend.Models;
using Homework.Enums;
using Homework.helper;
using Homework.Models;

namespace Homework.Areas.Backend.Controllers
{
    [Authorize(Users = "vip@test.com")]
    public class EditController : Controller
    {
        DateTime _Date = DateTime.Today.Date;

        private readonly EnumHelper _EnumHelper = new EnumHelper();

        // GET: Edit
        public ActionResult EditPage()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

        public List<MoneyListDisplayModel> DisplayList(DateTime date)
        {
            var skillTreeHomeworkEntities = new SkillTreeHomeworkEntities1();

            return skillTreeHomeworkEntities.AccountBooks
                .Where(a => a.Dateee == date)
                .Select(a => new MoneyListDisplayModel()
                {
                    Id = a.Id.ToString(),
                    CategoryDisplay = a.Categoryyy,
                    Money = a.Amounttt,
                    Date = a.Dateee
                }).ToList();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPage([Bind(Include = "Date")] SearchList searchList)
        {
            _Date = searchList.Date;
            return PartialView("List", DisplayList(searchList.Date));
        }
    }
}