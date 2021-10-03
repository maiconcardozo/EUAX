using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Componente.EUAX.Acao
{
  public class ProjetoMap : IEntityTypeConfiguration<Projeto>
  {
    public void Configure(EntityTypeBuilder<Projeto> builder)
    {
      builder.ToTable("Projeto");

      builder.HasKey(t => t.Codigo);

      builder.Property(t => t.Descricao).HasColumnName("Descricao");
      builder.Property(t => t.DataInicio).HasColumnName("DataInicio");
      builder.Property(t => t.DataFim).HasColumnName("DataFim");

      builder.Ignore("ListaCodigo");
    }
  }
}
