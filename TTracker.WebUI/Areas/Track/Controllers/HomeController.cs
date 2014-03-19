using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TTracker.WebUI.Areas.Track.Controllers
{
   

    public class HomeController : Controller
    {
        static List<Author> auths = new List<Author> { new Author{ author="IP", text="comment 1"},
                                new Author {author = "UP", text="comment 2"}};
        //
        // GET: /Track/Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReactTutorial()
        {
            return View();
        }

        public JsonResult ReactTutorialComments()
        {
            return Json(auths, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult ReactTutorialComments(Author auth)
        {
            auths.Add(auth);
            foreach (var a in auths)
                a.text = a.text + "-X";

            return Json(auths, JsonRequestBehavior.AllowGet);
        }
	}

    public class Author
    {
        public string author { get; set; }
        public string text { get; set; }
    }
}