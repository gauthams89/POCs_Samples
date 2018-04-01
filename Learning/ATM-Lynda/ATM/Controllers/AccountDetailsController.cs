using System.Web.Mvc;
using ATM.Models;

namespace ATM.Controllers
{
    public class AccountDetailsController : Controller
    {
        // GET: AccountDetails
        public ActionResult Details()
        {
            CheckingAccount account = new CheckingAccount
            {
                Id = 1,
                FirstName = "Gautham",
                LastName = "Sundar",
                AccountNumber = "MVCB00020120",
                Balance = 9000
            };
            return View(account);
        }

        public ActionResult NewAccount()
        {
            var checkingAccount = new CheckingAccount();
            return View(checkingAccount);
        }
        [HttpPost]
        public ActionResult NewAccount(CheckingAccount account)
        {
        // Code to save account

            return View("AccountCreationSuccess", account);
        }
    }
}