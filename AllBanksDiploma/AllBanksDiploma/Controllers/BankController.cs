using AllBanksDiploma.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AllBanksDiploma.Controllers
{
    public class BankController : Controller
    {
                
        // GET: Product
        public ActionResult Banks()
        {
            List<Bank> allBanks = new List<Bank>
            {
                new Bank {
                    BankName = "Альфа-Банк ЗАО",
                    Description ="Дочерний банк консорциума Альфа-Групп. Универсальный банк со специализацией на крупном корпоративном секторе и работе с ценными бумагами. В розничном сегменте активно развивает премиальные-продукты.",
                    WebPage = "www.alfabank.by"
                },
                new Bank {
                    BankName = "БТА Банк ЗАО",
                    Description = "БТА Банк - дочерний банк БТА Банк (Казахстан). На рынке с 2002 года. Развивает кредитование населения и малого и среднего бизнеса, торговое финансирование. Имеет отделения в Минске, Бресте, Могилеве и Витебске",
                    WebPage = "www.btabank.by"
                },
                new Bank {
                    BankName = "БПС-Сбербанк ОАО",
                    Description ="Один из крупнейших системообразующих банков. Имеет развитую сеть отделений по обслуживанию предприятий и населения в 47 городах Беларуси, крупный кредитор экономики. Принадлежит к группе Сбербанка России",
                    WebPage = "www.bps-sberbank.by"
                }
            };
            ViewBag.Banks = allBanks;
            return View();
        }
    }
}