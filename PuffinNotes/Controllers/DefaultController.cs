using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PuffinNotes.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/

        public ActionResult index()
        {
            ViewBag.title = "Home";  
            return View();
        }

    }
}
