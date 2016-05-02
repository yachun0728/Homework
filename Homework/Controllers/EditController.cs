using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework.Controllers
{
    [Authorize(Users = "vip@test.com")]
    public class EditController : Controller
    {
        // GET: Edit
        public ActionResult EditPage()
        {
            return View();
        }
    }
}