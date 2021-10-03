using System;

namespace Componente.EUAX.Acao
{
  public class Atividade : Acao, Entidade.Entidade
  {
    public int Codigo { get; set; }
    public bool Ativo { get; set; }
    public string Descricao { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public bool Finalizada { get; set; }

    public virtual Projeto Projeto { get; set; }
  }
}
