using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllBanksDiploma.Models
{
    public class CurrencyEx
    {
        public string Bank { get; set; }
        public decimal BuyUSD { get; set; }
        public decimal SellUSD { get; set; }
        public decimal BuyEUR { get; set; }
        public decimal SellEUR { get; set; }
        public decimal BuyRUB { get; set; }
        public decimal SellRUB { get; set; }
    }
}