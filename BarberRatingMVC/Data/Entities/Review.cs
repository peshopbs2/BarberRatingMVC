using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BarberRatingMVC.Data.Entities
{
    public class Review : BaseEntity
    {
        public string UserId { get; set; }
        public virtual User? User { get; set; }
        public int BarberId { get; set; }
        public virtual Barber? Barber { get; set; }
        [Required]
        [MaxLength(255)] 
        public string Description { get; set; }
        [Required]
        [Range(1, 5)]
        public int Rate { get; set; }
    }
}
