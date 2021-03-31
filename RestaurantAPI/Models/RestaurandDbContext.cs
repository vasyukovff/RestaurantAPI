using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPO.Models
{
    public class RestaurandDbContext : DbContext
    {

        public RestaurandDbContext(DbContextOptions<RestaurandDbContext> options) : base (options)
        {
             
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<OrderMaster> OrderMasters { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
