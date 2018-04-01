using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using DbModels = ATM.Db.Models;

namespace ATM.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private static ApplicationDbContext instance = null;
        public ApplicationDbContext()
            : base("MvcATMConnection")
        {
        }

        public DbSet<DbModels.CheckingAccount> CheckingAccounts { get; set; }
        public DbSet<DbModels.Transaction> Transactions { get; set; }

        public static ApplicationDbContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApplicationDbContext();
                }
                return instance;
            }
        }


    }
}