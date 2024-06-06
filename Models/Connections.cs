using Microsoft.EntityFrameworkCore;
namespace ApiEmpresa.Models;
public class Connections : DbContext 
{
    public Connections(DbContextOptions<Connections> options)
        : base(options)
    {
    }

    public DbSet<Clients> Clients { get; set; } = null!;
}