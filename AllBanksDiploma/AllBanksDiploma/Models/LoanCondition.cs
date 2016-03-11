﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllBanksDiploma.Models
{
    public class LoanCondition
    {
        public decimal Sum { get; set; }
        public double Rate { get; set; }
        public int Term { get; set; }
        public bool CalcType { get; set; }
    }
}