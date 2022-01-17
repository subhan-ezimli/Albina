using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
  public   class ProductPhoto:BaseEntity
    {
       
        public int OrderBy { get; set; }

        public int ProductId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Image { get; set; }

        public Product Product { get; set; }


    }
}
