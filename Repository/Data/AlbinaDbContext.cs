using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
   public class AlbinaDbContext :DbContext
    {
        public AlbinaDbContext(DbContextOptions<AlbinaDbContext> options) : base(options)
        {
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDiscounts> ProductDiscounts { get; set; }
        public DbSet<ProductOption> ProductOptions { get; set; }
        public DbSet<ProductOptionItem> ProductOptionItems { get; set; }
        public DbSet<ProductPhoto> productPhotos { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet< ProductSpecs> ProductSpecs { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<ShopCollection> ShopCollections { get; set; }
        public DbSet<SliderItem> SliderItems { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
