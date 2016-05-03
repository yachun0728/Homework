using System.Web.Mvc;

namespace Homework.Areas.Backend.Controllers
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