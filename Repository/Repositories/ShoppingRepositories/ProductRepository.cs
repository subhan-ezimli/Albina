using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.ShoppingRepositories
{
    public  class ProductRepository:IProductRepository
    {
        private readonly AlbinaDbContext _context; 
           
        public ProductRepository(AlbinaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetTopSellingProduct(int limit)
        {
            return _context.Products.Include("Photos")
                                    .Include("Label")      
                                    .Include("Discounts")
                                    .Where(p => p.Status)
                                    .Where(p => p.IsTopSelling)
                                    .OrderByDescending(p => p.AddedDate)
                                    .Take(limit)
                                    .ToList();
        }
    }
}
