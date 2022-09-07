using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_E_Perimetro
{
    public class Triangulo : IFigurasGeometricas
    {
        public double Altura { get; set; }
        public double Base { get; set; }
        public double LadoUm { get; set; }
        public double LadoDois { get; set; }
        public double LadoTres { get; set; }

        public Triangulo(double altura, double baseTriangulo, double ladoUm, double ladoDois, double ladoTres)
        {
            Altura = altura;
            Base = baseTriangulo;
            LadoUm = ladoUm;
            LadoDois = ladoDois;
            LadoTres = ladoTres;
        }

        public double AreaDaFigura()
        {
            return (Base * Altura) / 2;
        }
        public double AreaDoTrianguloEquilatero()
        {
            return (LadoUm * Altura) / 2;
        }
        public double PerimetroDaFigura()
        {
            return LadoUm + LadoDois + LadoTres;
        }
        public override string ToString()
        {
            if (LadoUm == LadoDois && LadoDois == LadoTres)
            { return $" Área: {AreaDoTrianguloEquilatero()} | Perímetro : {PerimetroDaFigura()}"; }
            else
            { return $" Área: {AreaDaFigura()} | Perímetro : {PerimetroDaFigura()}"; }
        }
    }
}
