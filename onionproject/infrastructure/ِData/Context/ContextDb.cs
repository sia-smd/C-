using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Domain;
using infrastructure.Entity;

namespace infrastructure.Context
{
    
    public class ContexDb:DbContext
    {
        public DbSet<student> Students  { get; set; }
        public DbSet<Course> Courses {get;set;}  

        protected override void OnConfiguring(DbContextOptionsBuilder db)
        {
            db.UseSqlServer("Data Source=.;initial catalog=StudentO;integrated security=true");

        }
        
    }
}