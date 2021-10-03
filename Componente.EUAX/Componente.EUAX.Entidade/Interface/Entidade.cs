using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componente.EUAX.Entidade
{
  public interface Entidade
  {
    int Codigo { get; set; }
    bool Ativo { get; set; }
    string Descricao { get; set; }
  }
}
