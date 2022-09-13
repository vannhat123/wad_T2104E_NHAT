using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WAD_T2104E_NHAT.Models
{
    public class ProductCategoryDbContext : DbContext
    {
        public ProductCategoryDbContext() : base("ProductCategoryConnection")
        { 
        }

        public DbSet<Category> CategoryList { get; set; }
        public DbSet<Product> ProductList { get; set; }
    }
}