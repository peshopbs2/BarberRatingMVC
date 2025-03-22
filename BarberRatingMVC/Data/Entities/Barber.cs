using System.ComponentModel.DataAnnotations;

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
        public string ImageUrl { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }
    }
}
