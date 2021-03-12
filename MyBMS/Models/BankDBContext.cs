using System;
using Microsoft.EntityFrameworkCore;
using MyBMS.Models.Entities;


namespace BMSEFDB.Models
{
    public class BankDBContext : DbContext
    {
        public BankDBContext(DbContextOptions<BankDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            // configure relationship between our tables
            modelBuilder.Entity<AccountHolder>()
                .HasOne(ach => ach.Account)
                .WithOne(ac => ac.AccountHolder);

            modelBuilder.Entity<AccountHolder>()
                .HasMany(ach => ach.Loans)
                .WithOne(ln => ln.AccountHolder);

            modelBuilder.Entity<AccountHolder>()
                .HasMany(ach => ach.OverDrafts)
                .WithOne(ov => ov.AccountHolder);

            //Configure primary key for account
            modelBuilder.Entity<Account>()
                .HasKey(ac => ac.AccountHolderId);

            // Adding Constraints to AccountHolder table
            modelBuilder.Entity<AccountHolder>()
                .Property(ach => ach.FirstName)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<AccountHolder>()
                .Property(ach => ach.LastName)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<AccountHolder>()
                .Property(ach => ach.MiddleName)
                .HasMaxLength(255);
            modelBuilder.Entity<AccountHolder>()
                .Property(ach => ach.Email)
                .IsRequired();
            modelBuilder.Entity<AccountHolder>()
                .Property(ach => ach.PhoneNumber)
                .IsRequired()
                .HasMaxLength(11);
            modelBuilder.Entity<AccountHolder>()
                .Property(ach => ach.Address)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<AccountHolder>()
                .Property(ach => ach.Password)
                .IsRequired();
            modelBuilder.Entity<AccountHolder>()
                .Property(ach => ach.DateOfBirth)
                .IsRequired();


        }





        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountHolder> AccountHolders { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Overdraft> Overdrafts { get; set; }
    }
}
