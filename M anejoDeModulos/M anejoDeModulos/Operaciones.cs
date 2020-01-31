using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_anejoDeModulos
{
    public class Operaciones
    {
        public double Calculo(Articulo a, Articulo b, Articulo c)
        {
            double Resultado=0;
            Resultado = (a.Precio + b.Precio + c.Precio) * 1.15;
            return Resultado;
        }
    }
}
