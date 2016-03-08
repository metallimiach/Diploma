using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AllBanksDiploma.Models
{
    public class BankContext : DbContext
    {
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }
        public DbSet<Currency> Currency { get; set; }
    }
}