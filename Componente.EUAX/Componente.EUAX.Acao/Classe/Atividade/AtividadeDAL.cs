using Componente.EUAX.Acao;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Componente.EUAX.Acao
{
  public class AtividadeDAL
  {
    internal static void ObterListaAtividade(List<Atividade> _ListaAtividade, AcaoContext _Context)
    {
      IQueryable<Atividade> query = _Context.ListaAtividadeDB;

      _ListaAtividade.AddRange(query);
    }

    internal static void AlterarAtividade(Atividade _Atividade, AcaoContext _Context)
    {
      using (var AcaoContext = new AcaoContext())
      {
        AcaoContext.Entry(_Atividade).State = EntityState.Modified;
      }
    }
  }
}
