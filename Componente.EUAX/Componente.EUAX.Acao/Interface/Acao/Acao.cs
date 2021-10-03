using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componente.EUAX.Acao
{
  public interface Acao
  {
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
  }
}
 