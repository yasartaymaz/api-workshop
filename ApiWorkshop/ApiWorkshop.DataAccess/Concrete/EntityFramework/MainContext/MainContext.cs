using ApiWorkshop.Core.Configuration;
using ApiWorkshop.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWorkshop.DataAccess.Concrete.EntityFramework.MainContext
{
    public class MainContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql(ConfigurationHelper.GetDbContext(Core.Constants.DatabaseContexts.MainContext));
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConfigurationHelper.GetDbContext(Core.Constants.DatabaseContexts.MainContext));
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
