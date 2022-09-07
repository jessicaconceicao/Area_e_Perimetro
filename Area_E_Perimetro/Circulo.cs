using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_E_Perimetro
{
    public class Circulo : IFigurasGeometricas
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public double AreaDaFigura()
        {
            return 3.14 * Math.Pow(Raio, 2);
        }

        public double PerimetroDaFigura()
        {
            return 2 * 3.14 * Raio;
        }
        public override string ToString()
        {
            return $" Área: {AreaDaFigura()} | Perímetro : {PerimetroDaFigura()}";
        }
    }
}
