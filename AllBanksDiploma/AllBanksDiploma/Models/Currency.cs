using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllBanksDiploma.Models
{
    public class Currency
    {
        public int CurrencyId { get; set; }
        public string CurrencyMnemonic { get; set; }
        public string CurrencyName { get; set; }
        public virtual ExchengeRate ExchangeRate { get; set; }
    }
}