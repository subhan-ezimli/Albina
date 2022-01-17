using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.ContentRepositories
{
    public class ContentRepository : IContentRepository
    {
        private readonly AlbinaDbContext _context;
         public ContentRepository ( AlbinaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ShopCollection> GetShopCollections()
        {
            return _context.ShopCollections.Where(s => s.Status)
                                           .OrderBy(s => s.OrderBy)
                                           .ToList();
        }
         
        public IEnumerable<SliderItem> GetSliderItems()
        {
            return _context.SliderItems.Where(s => s.Status)
                                       .OrderBy(s => s.OrderBy)
                                       .ToList();
        } 
    }
}
