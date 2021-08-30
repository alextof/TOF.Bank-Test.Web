using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace TOF.Bank_Test.Model
{
    public class BankContext: DbContext
    {
        public BankContext(DbContextOptions<BankContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Accounts");
            modelBuilder.Entity<Transfer>().ToTable("Transfers");
        }
    }
}
