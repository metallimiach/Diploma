using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllBanksDiploma.Models
{
    public class Deposit
    {
        public int DepositId { get; set; }
        public int BankId { get; set; }
        public string DepositName { get; set; }
        public string TermType { get; set; }
        public int Term { get; set; }
        public double DepositRate { get; set; }
        public virtual Currancy Currancy { get; set; }
        public virtual Bank Bank { get; set; }
    }
}