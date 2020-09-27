using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TestBd.Models;

namespace TestBd
{
    class TestContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=test.dbb;Trusted_Connection=True;");
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlServer("Data Source=Test");
        public DbSet<Account> Accounts { get; set; }
    }
}
