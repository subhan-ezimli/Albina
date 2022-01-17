using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
  public   class ProductDiscounts:BaseEntity
    {
        public int Id { get; set; }
        public int DiscountId { get; set; }
        public int  ProductId { get; set; }

        public Discount Discount { get; set; }
        public Product Product { get; set; }

    }
}
