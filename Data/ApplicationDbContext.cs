using Microsoft.EntityFrameworkCore;
using Proyecto.Models;

namespace proyecto_aspnet.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Tables de la BBDD
    public DbSet<Felidae> Felidae => Set<Felidae>();
    public DbSet<Weapon> Weapon => Set<Weapon>();
    
}
