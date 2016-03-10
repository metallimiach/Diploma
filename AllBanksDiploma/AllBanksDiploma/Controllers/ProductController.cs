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
    public class ProductController : Controller
    {
        BankContext db = new BankContext();

        public ActionResult Deposits()
        {
            var deposits = db.Deposits.Include(b => b.Bank).OrderBy(o => o.BankId);
            ViewBag.Deposits = deposits.ToList();
            return View();
        }

        public ActionResult Loans()
        {
            var loans = db.Loans.Include(b => b.Bank).OrderBy(o => o.BankId);
            ViewBag.Loans = loans.ToList();
            return View();
        }

        public ActionResult CurrencyExchange()
        {
            var groups = db.ExchangeRates.Include(b => b.Currency).Include(b => b.Bank);
            List<CurrencyEx> currencyExchange = new List<CurrencyEx>();
            foreach (var g in groups.GroupBy(b => b.Bank.BankName))
            {
                CurrencyEx ce = new CurrencyEx();
                ce.Bank = g.Key;

                foreach (var p in g)
                {
                    if (p.CurrencyId == 2)
                    {
                        ce.BuyUSD = (decimal)p.BuyRate;
                        ce.SellUSD = (decimal)p.SellRate;
                    }
                    else if (p.CurrencyId == 3)
                    {
                        ce.BuyEUR = (decimal)p.BuyRate;
                        ce.SellEUR = (decimal)p.SellRate;
                    }
                    else if (p.CurrencyId == 1)
                    {
                        ce.BuyRUB = (decimal)p.BuyRate;
                        ce.SellRUB = (decimal)p.SellRate;
                    }
                }
                currencyExchange.Add(ce);
            }
            ViewBag.CurrencyExchange = currencyExchange.ToList();
            return View();
        }
    }
}