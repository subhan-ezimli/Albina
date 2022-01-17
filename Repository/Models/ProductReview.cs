using System.ComponentModel.DataAnnotations;
namespace Repository.Models
{
    public class ProductReview:BaseEntity
    {
      
        public int ProductId { get; set; }
        public int  UserId { get; set; }
        public byte Star { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Review { get; set; }

        [MaxLength(100)]
        public string File { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }
    }
}
