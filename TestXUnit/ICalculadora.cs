using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoXUnit
{
    public interface ICalculadora
    {
        (string operacao, double resultado) Calcular(string operacao, double a, double b);
    }
}
