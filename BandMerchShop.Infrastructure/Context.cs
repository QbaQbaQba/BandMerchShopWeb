using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BandMerchShop.Domain.Model;

namespace BandMerchShop.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ItemOrder> ItemOrder { get; set; }
        
        public Context(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ItemOrder>()
                .HasKey(io => new { io.ItemId, io.OrderId });
            builder.Entity<ItemOrder>()
                .HasOne<Item>(io => io.Item)
                .WithMany(i => i.ItemOrders)
                .HasForeignKey(io => io.ItemId);
            builder.Entity<ItemOrder>()
                .HasOne<Order>(io => io.Order)
                .WithMany(o => o.ItemOrders)
                .HasForeignKey(io => io.OrderId);
        }
    }
}
