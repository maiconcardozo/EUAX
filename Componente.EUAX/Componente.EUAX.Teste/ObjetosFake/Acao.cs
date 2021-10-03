using Componente.EUAX.Acao;
using System;
using System.Collections.Generic;

namespace Componente.EUAX.Teste
{
  public static class ProjetoObejeto
  {
    public const Boolean Ativo = true;
    public const String Descricao = "Sou um teste de um processo";
    public static readonly DateTime DataInicio = DateTime.Now;
    public static readonly DateTime DataFim = DateTime.Now.AddMonths(1);

    public static readonly ICollection<Atividade> ListaAtividade = new List<Atividade>();
  }

  public static class ContactObject
  {
    public const String Name = "Maicon";
    public const String Email = "maicon_sonata@hotmail.com";
    public const String Site = "https://www.facebook.com/maicon.sonata";
  }

  public static class PhoneObject
  {
    public const Boolean Active = true;
    public const String OperatorPhone = "TIM";
    public const Int64 PhoneNumber = 96776359;
    public const Int32 AreaCode = 81;
  }

  public static class JuridicalPersonObject
  {
    public const Int64 Documentation = 07624847990;
    public const String Name = "Maicon Cardozo Pessoa Juridica";
    public const String TradeName = "CM Haste";
  }


}