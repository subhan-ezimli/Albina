using System.ComponentModel.DataAnnotations;
namespace Repository.Models
{
     public class ShopCollection:BaseEntity
    {  [Required]
        public int OrderBy { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Image { get; set; }

        [Required]
        [MaxLength(200)]
        public string EndPoint { get; set; }
    }
}
