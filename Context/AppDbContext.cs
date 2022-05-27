using ApiTreinamento.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApiTreinamento.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}
    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Produto>? Produtos { get; set; }
    public DbSet<Compra>? Compras { get; set; }
    public DbSet<Promocao>? Promocoes { get; set; }

}
