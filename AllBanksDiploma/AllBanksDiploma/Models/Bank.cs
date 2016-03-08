using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllBanksDiploma.Models
{
    public class Bank
    {
        public int BankId { get; set; } //id Банка
        public string BankName { get; set; } //Название
        public string Description { get; set; } //Описание
        public string WebPage { set; get; } //Вэб-страница
        public byte[] ImageData { set; get; } // Изображение
        public string ImageMimeType { set; get; } // Mime тип изображения
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }
        public virtual ICollection<ExchangeRate> ExchangeRates { get; set; }
    }
}