﻿using Tienda.Web.Data.Entities;

namespace Tienda.Web.Data
{
    public class DataContext : DbContext 
    {
        public DbSet<Product> Products { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        
    }
}
