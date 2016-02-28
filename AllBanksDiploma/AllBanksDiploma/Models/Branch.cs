using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllBanksDiploma.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public int BankId { get; set; }
        public string BranchName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string Phone { get; set; }
        public virtual Bank Bank { get; set; }
    }
}