using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllBanksDiploma.Models
{
    public class Loan
    {
        public int LoanId { get; set; }
        public int BankId { get; set; }
        public string LoanName { get; set; }
        public string TermType { get; set; }
        public int Term { get; set; }
        public double LoanRate { get; set; }
        public virtual Bank Bank { get; set; }
    }
}