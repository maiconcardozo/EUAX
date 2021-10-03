using System;
using System.Collections.Generic;

namespace Componente.EUAX.Acao
{
  public class AtividadeBLL
  {
    public static void CarregaAtividade(List<Atividade> _ListaAtividade)
    {
      using (AcaoContext MenuContext = new AcaoContext())
      {
        AtividadeDAL.ObterListaAtividade(_ListaAtividade, MenuContext);
      }
    }

    internal static void AlterarAtividade(Atividade _Atividade, AcaoContext _AcaoContext)
    {
      AtividadeDAL.AlterarAtividade(_Atividade, _AcaoContext);
    }
  }
}
