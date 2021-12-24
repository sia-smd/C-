using Microsoft.EntityFrameworkCore;

namespace entity
{
    public class connect:DbContext
    {
        public DbSet<student> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder db)
        {
            db.UseSqlServer("Data Source=.;initial catalog=entity;integrated security=true");

        }
        
    }
    
}