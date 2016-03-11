namespace AllBanksDiploma.Models
{
    public class DepositIncome
    {
        public string BankName { get; set; }
        public string DepositName { get; set; }
        public int Term { get; set; }
        public double Rate { get; set; }
        public decimal Sum { get; set; }
        public decimal Income { get; set; } 
    }
}