using AllBanksDiploma.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AllBanksDiploma.Controllers
{
    public class BankController : Controller
    {
        BankContext db = new BankContext();
                
        // GET: Bank
        public ActionResult List()
        {
            IEnumerable<Bank> banks = db.Banks;
            ViewBag.Banks = banks;
            return View();
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            ViewBag.BankId = id;
            return View();
        }
        [HttpPost]
        public ActionResult Details()
        {

            return View();
        }
    }
}