using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Componente.EUAX.Acao
{
  public class AtividadeMap : IEntityTypeConfiguration<Atividade>
  {
    public void Configure(EntityTypeBuilder<Atividade> builder)
    {
      builder.ToTable("Atividade");

      builder.HasKey(t => t.Codigo);

      builder.Property(t => t.Ativo).HasColumnName("Ativo");
      builder.Property(t => t.Descricao).HasColumnName("Descricao");
      builder.Property(t => t.DataInicio).HasColumnName("DataInicio");
      builder.Property(t => t.DataFim).HasColumnName("DataFim");
      builder.Property(t => t.Finalizada).HasColumnName("Finalizada");
    }
  }
}
