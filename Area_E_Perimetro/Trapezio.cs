using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_E_Perimetro
{
    public class Trapezio : IFigurasGeometricas
    {
        public double BaseMaior { get; set; }
        public double BaseMenor { get; set; }
        public double Altura { get; set; }
        public double LadoUm { get; set; }
        public double LadoDois { get; set; }
        public double LadoTres { get; set; }
        public double LadoQuatro { get; set; }
        public Trapezio(double baseMaior, double baseMenor, double altura, double ladoUm, double ladoDois, double ladoTres, double ladoQuatro)
        {
            BaseMaior = baseMaior;
            BaseMenor = baseMenor;
            Altura = altura;
            LadoUm = ladoUm;
            LadoDois = ladoDois;
            LadoTres = ladoTres;
            LadoQuatro = ladoQuatro;
        }

        public double AreaDaFigura()
        {
            return (BaseMaior + BaseMenor) * Altura / 2;
        }

        public double PerimetroDaFigura()
        {
            return LadoUm + LadoDois + LadoTres + LadoQuatro;
        }
        public override string ToString()
        {
            return $" Área: {AreaDaFigura()} | Perímetro : {PerimetroDaFigura()}";
        }
    }
}
