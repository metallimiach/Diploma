using AllBanksDiploma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data;

namespace AllBanksDiploma.Controllers
{
    public class BankController : Controller
    {
        BankContext db = new BankContext();
          
        public ActionResult List()
        {
            return View(db.Banks);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var branches = db.Branches.Include(b => b.Bank).Where(i => i.Bank.BankId == id);
            ViewBag.Branches = branches.ToList();
            foreach(var g in branches.GroupBy(b => b.Bank.BankName))
            {
                ViewBag.Bank = g.Key;
            }            
            return View();
        }        
    }
}