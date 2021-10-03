using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Componente.EUAX.Acao
{
  public class ProjetoBLL
  {
    /// <summary>
    /// Método chamado para carregamento dos projetos
    /// </summary>
    /// <param name="_Projeto"></param>
    /// <param name="_ListaProjeto"></param>
    public static void CarregaProjeto(Projeto _Projeto, List<Projeto> _ListaProjeto)
    {
      using (var AcaoContext = new AcaoContext())
      {
        ProjetoDAL.ObterListaProjeto(_Projeto, _ListaProjeto, AcaoContext);
      }
    }

    public static void InserirProjeto(Projeto _Projeto)
    {
      using (var AcaoContext = new AcaoContext())
      {
        try
        {
          if (_Projeto.DataInicio != _Projeto.ListaAtividade.FirstOrDefault().DataInicio)
          {
            throw new Exception("A data inicial do projeto deve ser igual a data inicial da primeira atividade");
          }

          _Projeto.ListaAtividade.Last().DataFim = _Projeto.DataFim;

          ProjetoDAL.InserirProjeto(_Projeto, AcaoContext);

        }
        catch (Exception ex)
        {
          throw;
        }
      }
    }

    public static void AlterarProjeto(Projeto _Projeto, AcaoContext _Context)
    {
      using (var AcaoContext = new AcaoContext())
      {
        foreach (var item in _Projeto.ListaAtividade)
        {
          AtividadeBLL.AlterarAtividade(item, AcaoContext);
        }

        ProjetoDAL.AlterarProjeto(_Projeto, _Context);
      }
    }
  }
}
