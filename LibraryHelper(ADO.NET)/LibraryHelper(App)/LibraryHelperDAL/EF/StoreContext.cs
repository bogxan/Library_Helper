using LibraryHelperDAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryHelperDAL.EF
{
    public class StoreContext: DbContext
    {
        private readonly string connectionString = string.Empty;
        public DbSet<Book> Books { get; set; }
        public DbSet<LendBook> LendBooks { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public StoreContext(string connectionString)
        {
            this.connectionString = connectionString;
            Database.EnsureCreated();
        }
        public StoreContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(p => p.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Book>().Property(p => p.Genre).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Book>().Property(p => p.Authors).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Book>().Property(p => p.CountPages).HasDefaultValue(3).IsRequired();
            modelBuilder.Entity<Book>().Property(p => p.IsLendedOut).HasDefaultValue(false).IsRequired();
            modelBuilder.Entity<Book>().Property(p => p.PublishOffice).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Book>().Property(p => p.PublishDate).HasDefaultValue(1).IsRequired();
            modelBuilder.Entity<LendBook>().Property(p => p.DateLendingFrom).HasDefaultValue(new DateTime(2000, 01, 01)).IsRequired();
            modelBuilder.Entity<LendBook>().Property(p => p.DateLendingTo).HasDefaultValue(new DateTime(2000, 01, 01)).IsRequired();
            modelBuilder.Entity<Reader>().Property(p => p.FirstName).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Reader>().Property(p => p.LastName).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Reader>().Property(p => p.PhoneNumber).HasMaxLength(13).IsRequired();
        }
    }
}
