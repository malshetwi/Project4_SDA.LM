using malshetwi_Project4_SDA.LMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace malshetwi_Project4_SDA.LMS.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // mapping table for SQL Side
            modelBuilder.Entity<Order>().HasKey(inOrder => new
            {
                inOrder.OrderID, //~ here i solve issue about accepting OrderID to be PK
           
            });

            // mapping table for C# Side

            modelBuilder.Entity<Order>().HasOne(InItem => InItem.Item).WithMany(inOrder => inOrder.Order).HasForeignKey(InItem =>
            InItem.ItemID);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
