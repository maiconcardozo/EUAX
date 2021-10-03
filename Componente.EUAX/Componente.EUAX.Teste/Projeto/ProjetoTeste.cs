using Componente.EUAX.Acao;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace Componente.EUAX.Teste
{

  public class AcaoTeste
  {
    [Test]
    public void TesteProjetoInserir()
    {
      Projeto Projeto = new();

      Projeto.Descricao = ProjetoObejeto.Descricao;
      Projeto.DataInicio = ProjetoObejeto.DataInicio;
      Projeto.DataFim = ProjetoObejeto.DataFim;
      Projeto.ListaAtividade = new List<Atividade>();
      Projeto.Ativo = ProjetoObejeto.Ativo;

      //Simulando a tela, caso criamos a primeira atividade, automaticamente devemos colocar a data de inicio do projeto.
      //Então faço uma verificação se caso 
      for (int i = 0; i < 5; i++)
      {
        Atividade at = new();

        at.Ativo = true;
        if (i == 0)
        {
          at.DataInicio = Projeto.DataInicio;
        }

        at.Descricao = "Atividade  " + i;
        at.Finalizada = false;
        at.Projeto = Projeto;
        Projeto.ListaAtividade.Add(at);
      }

      ProjetoBLL.InserirProjeto(Projeto);

      List<Projeto> ProjetoPesquisa = new List<Projeto>();
      ProjetoBLL.CarregaProjeto(Projeto, ProjetoPesquisa);

      Assert.IsNotNull(ProjetoPesquisa.FirstOrDefault(), "Aconteceu algum problema para inserir o projeto");
    }

    [Test]
    public void TesteProjetoAlterar()
    {

      Projeto Projeto = new();

      List<Projeto> ProjetoPesquisa = new List<Projeto>();
      ProjetoBLL.CarregaProjeto(Projeto, ProjetoPesquisa);

      Projeto p = ProjetoPesquisa.FirstOrDefault();



    }
  }
}
