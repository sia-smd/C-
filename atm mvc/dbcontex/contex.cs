using Microsoft.EntityFrameworkCore;

namespace atm_mvc
{
    public class connect:DbContext
    {
        public DbSet<user> Users { get; set; }
         public DbSet<account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder db)
        {
            db.UseSqlServer("Data Source=.;initial catalog=ATM;integrated security=true");

        }
        
    }
    
}