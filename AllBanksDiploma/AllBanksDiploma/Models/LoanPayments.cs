using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllBanksDiploma.Models
{
    public class LoanPayments
    {
        public string Date { get; set; }
        public decimal Debt { get; set; }
        public decimal Interest { get; set; }
        public decimal Total { get; set; }
        public decimal Balance { get; set; }
    }
}