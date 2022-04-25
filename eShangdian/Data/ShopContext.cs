using eShangdian.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShangdian.Data
{
    public class ShopContext: DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options): base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Models.Attribute> Attributes { get; set; }
        public DbSet<AttributeDescription> AttributeDescriptions { get; set; }
        public DbSet<AttributeGroup> AttributeGroups { get; set; }
        public DbSet<AttributeGroupDescription> AttributeGroupDescriptions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryDescription> CategoryDescriptions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerGroup> CustomerGroups { get; set; }
        public DbSet<CustomerGroupDescription> CustomerGroupDescriptions { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<ProductDescription> ProductDescriptions { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagDescription> TagDescriptions { get; set; }
    }
}
