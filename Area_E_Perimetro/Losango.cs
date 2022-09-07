using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_E_Perimetro
{
    public class Losango : IFigurasGeometricas
    {
        public double DiagonalMaior { get; set; }
        public double DiagonalMenor { get; set; }
        public double Lado { get; set; }
        public Losango(double diagonalMaior, double diagonalMenor, double lado)
        {
            DiagonalMaior = diagonalMaior;
            DiagonalMenor = diagonalMenor;
            Lado = lado;
        }

        public double AreaDaFigura()
        {
            return (DiagonalMaior * DiagonalMenor) / 2;
        }

        public double PerimetroDaFigura()
        {
            return 4 * Lado;
        }
        public override string ToString()
        {
            return $" Área: {AreaDaFigura()} | Perímetro : {PerimetroDaFigura()}";
        }
    }
}
