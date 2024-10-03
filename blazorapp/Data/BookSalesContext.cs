using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace blazorapp.Data;

public partial class BookSalesContext : DbContext
{
    public BookSalesContext()
    {
    }

    public BookSalesContext(DbContextOptions<BookSalesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booksale> Booksales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL("server=localhost;database=BookSales;uid=root;password=root");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booksale>(entity =>
        {
            entity.HasKey(e => e.SaleId).HasName("PRIMARY");

            entity.ToTable("booksale");

            entity.Property(e => e.SaleId).HasColumnName("saleID");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
