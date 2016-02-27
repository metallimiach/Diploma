using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AllBanksDiploma.Controllers
{
    public class ContentController : Controller
    {
        public ActionResult Banks()
        {
            return View();
        }
        public ActionResult Deposits()
        {
            return View();
        }
        public ActionResult Loans()
        {
            return View();
        }
        public ActionResult Currency()
        {
            return View();
        }
    }
}