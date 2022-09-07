using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_E_Perimetro
{
    public class Quadrado : IFigurasGeometricas
    {
        public double Lado { get; set; }

        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public double AreaDaFigura()
        {
            return Math.Pow(Lado, 2);
        }

        public double PerimetroDaFigura()
        {
            return Lado * 4;
        }

        public override string ToString()
        {
            return $" Área: {AreaDaFigura()} | Perímetro : {PerimetroDaFigura()}";
        }
    }
}
