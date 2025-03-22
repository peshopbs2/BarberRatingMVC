using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarberRatingMVC.Data.Entities
{
    public class Barber : BaseEntity
    {
        [Required]
        [MaxLength(64)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }

    }
}
