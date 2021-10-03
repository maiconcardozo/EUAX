using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;

namespace Componente.EUAX.Acao
{
  public interface IProjetoContext
  {
    DbSet<Projeto> ListaProjetoDB { get; set; }
    DbSet<Atividade> ListaAtividadeDB { get; set; }
  }

  public class AcaoContext : DbContext, IProjetoContext
  {

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
          .AddJsonFile("appsettings.json")
          .Build();
      optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
    }

    public DbSet<Projeto> ListaProjetoDB { get; set; }
    public DbSet<Atividade> ListaAtividadeDB { get; set; }

    protected override void OnModelCreating(ModelBuilder _ModelBuilder)
    {
      OnConfiguring(_ModelBuilder);
    }

    public static void OnConfiguring(ModelBuilder _ModelBuilder)
    {
      _ModelBuilder.ApplyConfiguration(new ProjetoMap());
      _ModelBuilder.ApplyConfiguration(new AtividadeMap());
    }
  }
}