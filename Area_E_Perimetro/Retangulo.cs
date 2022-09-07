using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_E_Perimetro
{
    public class Retangulo : IFigurasGeometricas
    {
        public double Altura { get; set; }
        public double Base { get; set; }
        public Retangulo(double altura, double baseRatangulo)
        {
            Altura = altura;
            Base = baseRatangulo;

        }

        public double AreaDaFigura()
        {
            return Base * Altura;
        }

        public double PerimetroDaFigura()
        {
            return 2 * (Base * Altura);
        }
        public override string ToString()
        {
            return $" Área: {AreaDaFigura()} | Perímetro : {PerimetroDaFigura()}";
        }
    }
}
