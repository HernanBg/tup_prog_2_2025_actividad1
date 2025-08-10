using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class RectanguloDesarrollado : Rectangulo
    {
        public RectanguloDesarrollado(double radio, double altura) : base(2 * Math.PI * radio, altura)
        {
        }

        public override string Describir()
        {
            var culture = CultureInfo.InvariantCulture;

            return @$"
{{ 
  ""Tipo"": ""RectanguloDesarrollado"", 
  ""Largo"": {Largo.ToString("f2", culture)}, 
  ""Ancho"": {Ancho.ToString("f2", culture)}, 
  ""Area"": {CalcularArea().ToString("f2", culture)}
}}";
        }
    }
}
