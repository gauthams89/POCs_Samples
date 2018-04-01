using System.Linq;
using System.Web.Mvc;
using VM = ATM.Models;
using DbM = ATM.Db.Models;
using Microsoft.AspNet.Identity;

namespace ATM.Controllers
{
    [Authorize]
    public class TransactionController : Controller
    {
        // GET: Transaction
        public ActionResult Index(string type)
        {
            if (string.IsNullOrEmpty(type))
            {
                type = "d";
            }
            var currentUserId = User.Identity.GetUserId();
            var dbContext = VM.ApplicationDbContext.Instance;
            var checkingAccount = dbContext.CheckingAccounts.Where(ca => ca.ApplicationUserId == currentUserId).FirstOrDefault();
            if (checkingAccount == null)
            {
                return View(new VM.Transaction());
            }
            var transaction = new VM.Transaction
            {
                CheckingAccountId = checkingAccount.Id,
                Type = type[0]
            };
            return View(transaction);
        }
        [HttpPost]
        public ActionResult Index(VM.Transaction transaction)
        {
            var transactionDb = new DbM.Transaction
            {
                CheckingAccountId = transaction.CheckingAccountId,
                Amount = transaction.Type == 'd' ? transaction.Amount : -1 * transaction.Amount
            };
            var dbContext = VM.ApplicationDbContext.Instance;
            dbContext.Transactions.Add(transactionDb);
            dbContext.SaveChanges();
            return View("TransactionSuccess");
        }
    }
}