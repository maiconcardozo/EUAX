using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Componente.EUAX.Acao
{
  public class ProjetoDAL
  {
    internal static void ObterListaProjeto(Projeto _Projeto, List<Projeto> _ListaProjeto, AcaoContext _Context)
    {
      IQueryable<Projeto> query = _Context.ListaProjetoDB.Include(x => x.ListaAtividade);

      if (_Projeto.Codigo != 0)
      {
        query = query.Where(p => p.Codigo == _Projeto.Codigo);
      }
      else if (_Projeto.ListaCodigo != null)
      {
        query = query.Where(p => _Projeto.ListaCodigo.Contains(p.Codigo));
      }

      _ListaProjeto.AddRange(query);
    }

    internal static void InserirProjeto(Projeto _Projeto, AcaoContext _AcaoContext)
    {
      _AcaoContext.Add(_Projeto);
      _AcaoContext.AddRange(_Projeto.ListaAtividade);

      _AcaoContext.SaveChanges();
    }

    internal static void AlterarProjeto(Projeto _Projeto, AcaoContext _AcaoContext)
    {
      _AcaoContext.Entry(_Projeto).State = EntityState.Modified;
    }
  }
}

