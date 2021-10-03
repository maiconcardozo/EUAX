using Componente.EUAX.Acao;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;

namespace Componente.Agisyst.Web.WebUtils
{
  public class EUAXContext : DbContext
  {

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
          .AddJsonFile("appsettings.json")
          .Build();
      optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder _ModelBuilder)
    {
      AcaoContext.OnConfiguring(_ModelBuilder);
    }
  }
}