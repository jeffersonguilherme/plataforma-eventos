using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infra.Persistence;

public class EventoDbContext : DbContext
{
    public DbSet<Evento> Eventos { get; set; }
    public DbSet<Inscricao> Inscricoes { get; set; }
    public DbSet<Participante> Participantes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=localhost,1433;Database=Eventos;User ID=sa;Password=Xy23h2o1@Sql;TrustServerCertificate=True");
    }
 }