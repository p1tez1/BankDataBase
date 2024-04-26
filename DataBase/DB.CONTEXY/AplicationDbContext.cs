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
        public DbSet<Employes> Employes { get; set; }
        public DbSet<S_Path> S_Paths { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(a => a.Id);
                entity.Property(a => a.Id).IsRequired();

                entity.HasOne(x => x.)
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(a => a.Id);
                entity.Property(a => a.Id).IsRequired();

                entity.HasMany(x => x.CardIds).WithOne(item => item.Id)
            });
        }
    }
}