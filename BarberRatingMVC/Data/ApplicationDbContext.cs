using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BarberRatingMVC.Data.Entities;
using BarberRatingMVC.Models;

namespace BarberRatingMVC.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

public DbSet<BarberRatingMVC.Data.Entities.Barber> Barber { get; set; } = default!;

public DbSet<BarberRatingMVC.Data.Entities.Review> Review { get; set; } = default!;

public DbSet<BarberRatingMVC.Models.UserViewModel> UserViewModel { get; set; } = default!;
}
