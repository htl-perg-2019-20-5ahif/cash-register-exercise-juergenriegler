using CashRegisterClassLibrary.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashRegisterAPI.Data
{
    public class CashRegisterDataContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Receipt> Receipts { get; set; }

        public DbSet<ReceiptLine> ReceiptLines { get; set; }


        public CashRegisterDataContext(DbContextOptions<CashRegisterDataContext> options)
                : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Required Fields on Product
            modelBuilder.Entity<Product>()
                .Property(p => p.ProductName)
                .IsRequired();
            modelBuilder.Entity<Product>()
                .Property(p => p.UnitPrice)
                .IsRequired();

            // Relationships
            // modelBuilder.Entity<Receipt>()
            //  .HasMany(r => r.ReceiptLines)
            //  .WithOne(r => r.Receipt);
        }

    }
}
