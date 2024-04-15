using DataBase.Program;
using Microsoft.EntityFrameworkCore;

namespace MyApplication.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employes> Employes { get; set; }
        public DbSet<S_Path> S_Paths { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}