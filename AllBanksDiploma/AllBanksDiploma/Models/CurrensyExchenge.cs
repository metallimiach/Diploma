using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllBanksDiploma.Models
{
    public class ExchengeRate
    {
        public int ExchancgeRateId { get; set; }
        public int CurrencyId { get; set; }
        public int BankId { get; set; }
        public double BuyRate { get; set; }
        public double SellRate { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Bank Bank { get; set; }
    }
}