using Microsoft.EntityFrameworkCore;
using OsDigitalMVP.Models;

namespace OsDigitalMVP.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<OrdemServico> OrdensServico { get; set; }
}