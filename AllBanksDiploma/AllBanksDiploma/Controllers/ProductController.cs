using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AllBanksDiploma.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
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