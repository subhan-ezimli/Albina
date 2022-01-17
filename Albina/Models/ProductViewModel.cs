using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Albina.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public IList<string> Photos { get; set; }       
        public byte StarCount { get; set; }

        public DiscountViewModel Discount { get; set; }
        public LabelViewModel Label { get; set; }
    }
}
