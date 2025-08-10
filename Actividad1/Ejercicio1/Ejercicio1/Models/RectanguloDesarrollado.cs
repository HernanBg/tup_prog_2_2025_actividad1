using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class RectanguloDesarrollado
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public RectanguloDesarrollado(double radio, double altura)
        {
            Ancho = 2 * Math.PI * radio;
            Largo = altura;
        }
        public double CalcularArea()
        {
            return Largo * Ancho;
        }

        public string Describir()
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
