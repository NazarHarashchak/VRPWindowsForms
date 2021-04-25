using System;
using System.Collections.Generic;
using System.Data.Entity;
using VRPWindowsForms.Models;

namespace VRPWindowsForms
{
    class DatabaseContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreType> StoreTypes { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarStatus> CarStatuses { get; set; }
        public DatabaseContext() : base("DefaulConnection")
        {
        }
    }
}
