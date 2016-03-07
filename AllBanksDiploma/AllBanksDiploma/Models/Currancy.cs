using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllBanksDiploma.Models
{
    public class Currancy
    {
        public int CurrencyId { get; set; }
        public int CurrencyCode { get; set; }
        public string CurrencyMnemonic { get; set; }
        public string CurrencyName { get; set; }
        public virtual Deposit Deposit { get; set; }
        public virtual ExchangeRate ExchangeRate { get; set; }
    }
}