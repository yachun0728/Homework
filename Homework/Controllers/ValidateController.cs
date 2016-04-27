using System;
using System.Web.Mvc;

namespace Homework.Controllers
{
    public class ValidateController : Controller
    {
        // GET: Validate
        public ActionResult Index(DateTime date)
        {
            if (date > DateTime.Now.Date)
            {
                return Json(false,JsonRequestBehavior.AllowGet);
            }
            return Json(true,JsonRequestBehavior.AllowGet);
        }
    }
}