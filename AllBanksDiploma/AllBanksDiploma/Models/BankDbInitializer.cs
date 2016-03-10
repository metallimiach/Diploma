using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AllBanksDiploma.Models
{
    public class BankDbInitializer : DropCreateDatabaseIfModelChanges<BankContext>
    {
        protected override void Seed(BankContext db)
        {
            db.Banks.Add(new Bank {
                BankName = "Альфа-Банк ЗАО",
                Description = "Дочерний банк консорциума Альфа-Групп. Универсальный банк со специализацией на крупном корпоративном секторе и работе с ценными бумагами. В розничном сегменте активно развивает премиальные-продукты.",
                WebPage = "www.alfabank.by"
            });
            db.Banks.Add(new Bank
            {
                BankName = "БТА Банк ЗАО",
                Description = "БТА Банк - дочерний банк БТА Банк (Казахстан). На рынке с 2002 года. Развивает кредитование населения и малого и среднего бизнеса, торговое финансирование. Имеет отделения в Минске, Бресте, Могилеве и Витебске",
                WebPage = "www.btabank.by"
            });
            db.Banks.Add(new Bank
            {
                BankName = "БПС-Сбербанк ОАО",
                Description = "Один из крупнейших системообразующих банков. Имеет развитую сеть отделений по обслуживанию предприятий и населения в 47 городах Беларуси, крупный кредитор экономики. Принадлежит к группе Сбербанка России",
                WebPage = "www.bps-sberbank.by"
            });
            base.Seed(db);
        }
    }
}