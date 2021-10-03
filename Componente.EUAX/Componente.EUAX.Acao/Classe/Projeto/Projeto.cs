

using System;
using System.Collections.Generic;

namespace Componente.EUAX.Acao
{
  public class Projeto : Acao, Entidade.Entidade
  {
    public Int32 Codigo { get; set; }
    public Boolean Ativo { get; set; }
    public String Descricao { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }

    public virtual ICollection<Atividade> ListaAtividade { get; set; }


    public List<Int32> ListaCodigo { get; set; }
  }
}
