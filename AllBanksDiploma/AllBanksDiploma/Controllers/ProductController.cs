using AllBanksDiploma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        [HttpPost]
        public ActionResult CalcDepositIncome(DepositConditions condition)
        {
            List<DepositIncome> Result = new List<DepositIncome>();
            var deposits = db.Deposits
                .Include(b => b.Bank)
                .Where(d => d.CurrCode == condition.Currency)
                .Where(d => d.DepositRate >= condition.Rate)
                .Where(d => d.Term <= condition.Term);
            foreach (var i in deposits.ToList())
            {
                DepositIncome tmp = new DepositIncome();
                tmp.BankName = i.Bank.BankName;
                tmp.DepositName = i.DepositName;
                tmp.Term = i.Term;
                tmp.Rate = i.DepositRate;
                tmp.Sum = condition.Sum;
                tmp.Income = CalcDepositIncome(condition.Sum, i.Term, i.DepositRate);
                Result.Add(tmp);
            }
            return View(Result);
        }

        [HttpPost]
        public ActionResult CalcLoanPayments(LoanCondition condition)
        {
            List<LoanPayments> Result = new List<LoanPayments>();
            decimal sum = condition.Sum;
            for (int i = 1; i < condition.Term + 1; i++)
            {
                LoanPayments payment = new LoanPayments();
                var date = DateTime.Today;
                date = date.AddMonths(i);
                payment.Date = string.Format("{0}-{1}", date.Month, date.Year);
                payment.Debt = 100;
                payment.Interest = 10;
                payment.Total = payment.Debt + payment.Interest;
                payment.Balance = 200;
                Result.Add(payment);

            }
            return View(Result);
        }

        private decimal CalcDepositIncome(decimal sum, int term, double rate)
        {
            decimal income = 0;
            double deposit = (double)sum;
            double q = rate / 100 / 12 + 1;
            for (int i = 0; i < term; i++)
            {
                deposit *= q;
            }
            return income=(decimal)(deposit-(double)sum);
        }
    }
}