using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Cuadrado : Rectangulo
    {
        public Cuadrado(double lado) : base(lado, lado)
        {
        }

        public override string Describir()
        {
            var culture = CultureInfo.InvariantCulture;

            return @$"{{ 
  ""Tipo"":""Cuadrado"", 
  ""Largo"": {Largo.ToString("f2", culture)}, 
  ""Ancho"": {Ancho.ToString("f2", culture)}, 
  ""Area"": {CalcularArea().ToString("f2", culture)}
}}";
        }
    }
}
