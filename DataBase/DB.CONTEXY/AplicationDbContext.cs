using DataBase.Program;
using Microsoft.EntityFrameworkCore;

namespace BankDataBase.DB.CONTEXY
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employes { get; set; }
        public DbSet<S_Path> S_Paths { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(a =>
            {
                a.HasMany(b => b.Cards)
                .WithOne()
                .HasForeignKey(c => c.AccountId);
            });

            modelBuilder.Entity<Card>(a =>
            {
                a.HasMany(t => t.Transactions)
                .WithOne()
                .HasForeignKey(c => c.CardId);
            });

            modelBuilder.Entity<Customer>(a =>
            {
                a.HasMany(c => c.Accounts)
                .WithOne()
                .HasForeignKey(b => b.CustomerId);
            });

            modelBuilder.Entity<Employee>(a =>
            {
                a.HasMany(c => c.Customers)
                .WithOne()
                .HasForeignKey(b => b.EmployeeId);
            });
        }
    }
}