using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Circulo : FiguraPlana
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        override public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override string Describir()
        {
            var culture = CultureInfo.InvariantCulture;

            return @$"{{  
  ""Tipo"":""Circulo"", 
  ""Radio"": {Radio.ToString("f2", culture)}, 
  ""Area"": {CalcularArea().ToString("f2", culture)}
}}";
        }
    }
}
