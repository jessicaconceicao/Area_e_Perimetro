//Calculando áreas planas


using Area_E_Perimetro;

Console.WriteLine("Qual tipo de área deseja calcular? [0]Quadrado [1]Retângulo [2]Circulo [3]Triângulo [4]Losango [5]Trapézio");
if (int.TryParse(Console.ReadLine(), out int entradaFigura) == false || entradaFigura < 0 || entradaFigura > 5)
{
    Console.WriteLine("Selecione uma opção válida");
    return;
}

FormaDaFigura forma;
switch (entradaFigura)
{
    case 0:
        forma = FormaDaFigura.Quadrado;
        Console.WriteLine("Qual a medida do lado?");
        if (double.TryParse(Console.ReadLine(), out double lado) == false || lado <= 0)
        { Console.WriteLine("Insira um valor válido"); }
        else
        {
            var quadrado = new Quadrado(lado);
            Console.WriteLine(quadrado.ToString());
        }
        break;
    case 1:
        forma = FormaDaFigura.Retângulo;
        Console.WriteLine("Qual a medida da base?");
        if (double.TryParse(Console.ReadLine(), out double baseRetangulo) == false || baseRetangulo <= 0)
        { Console.WriteLine("Insira um valor válido"); }
        else
        {
            Console.WriteLine("Qual a medida da altura?");
            if (double.TryParse(Console.ReadLine(), out double alturaRetangulo) == false || alturaRetangulo <= 0)
            { Console.WriteLine("Insira um valor válido"); }
            else
            {
                var retangulo = new Retangulo(alturaRetangulo, baseRetangulo);
                Console.WriteLine(retangulo.ToString());
            }
        }
        break;
    case 2:
        forma = FormaDaFigura.Circulo;
        Console.WriteLine("Qual a medida do raio?");
        if (double.TryParse(Console.ReadLine(), out double raio) == false || raio <= 0)
        { Console.WriteLine("Insira um valor válido"); }
        else
        {
            var circulo = new Circulo(raio);
            Console.WriteLine(circulo.ToString());
        }
        break;
    case 3:
        forma = FormaDaFigura.Triângulo;

        Console.WriteLine("Qual a medida da altura?");
        if (double.TryParse(Console.ReadLine(), out double altura) == false || altura <= 0)
        { Console.WriteLine("Insira um valor válido"); }
        else
        {
            Console.WriteLine("Qual a medida da base?");
            if (double.TryParse(Console.ReadLine(), out double baseTriagulo) == false || altura <= 0)
            { Console.WriteLine("Insira um valor válido"); }
            else
            {
                Console.WriteLine("Qual tipo de triângulo? [1]Equilátero [2]Outros");
                if (double.TryParse(Console.ReadLine(), out double equilatero) == false || equilatero < 1 || equilatero > 2)
                {
                    Console.WriteLine("Insira um valor válido");
                    return;
                }
                else if (equilatero == 1)
                {
                    Console.WriteLine("Qual a medida dos lados?");
                    if (double.TryParse(Console.ReadLine(), out double ladoEquilatero) == false || ladoEquilatero <= 0)
                    { Console.WriteLine("Insira um valor válido"); }
                    else
                    {
                        var triangulo = new Triangulo(altura, baseTriagulo, ladoEquilatero, ladoEquilatero, ladoEquilatero);
                        Console.WriteLine(triangulo.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("Qual a medida do primeiro lado");
                    if (double.TryParse(Console.ReadLine(), out double primeiroLado) == false || primeiroLado <= 0)
                    { Console.WriteLine("Insira um valor válido"); }
                    else
                    {
                        Console.WriteLine("Qual a medida do segundo lado?");
                        if (double.TryParse(Console.ReadLine(), out double segundoLado) == false || segundoLado <= 0)
                        { Console.WriteLine("Insira um valor válido"); }
                        else
                        {
                            Console.WriteLine("Qual a medida terceiro lado?");
                            if (double.TryParse(Console.ReadLine(), out double terceiroLado) == false || terceiroLado <= 0)
                            { Console.WriteLine("Insira um valor válido"); }
                            else
                            {
                                var triangulo = new Triangulo(altura, baseTriagulo, primeiroLado, segundoLado, terceiroLado);
                                Console.WriteLine(triangulo.ToString());
                            }
                        }
                    }
                }

            }
        }
        break;
    case 4:
        forma = FormaDaFigura.Losango;
        Console.WriteLine("Qual a medida da diagonal maior?");
        if (double.TryParse(Console.ReadLine(), out double diagonalMaior) == false || diagonalMaior <= 0)
        { Console.WriteLine("Insira um valor válido"); }
        else
        {
            Console.WriteLine("Qual a medida da diagonal menor?");
            if (double.TryParse(Console.ReadLine(), out double diagonalMenor) == false || diagonalMenor <= 0)
            { Console.WriteLine("Insira um valor válido"); }
            else
            {
                Console.WriteLine("Qual a medida do lado?");
                if (double.TryParse(Console.ReadLine(), out double ladoLosango) == false || ladoLosango <= 0)
                { Console.WriteLine("Insira um valor válido"); }
                else
                {
                    var losango = new Losango(diagonalMaior, diagonalMenor, ladoLosango);
                    Console.WriteLine(losango.ToString());
                }
            }
        }
        break;
    case 5:
        forma = FormaDaFigura.Trapézio;
        Console.WriteLine("Qual a medida da base maior?");
        if (double.TryParse(Console.ReadLine(), out double baseMaior) == false || baseMaior <= 0)
        { Console.WriteLine("Insira um valor válido"); }
        else
        {
            Console.WriteLine("Qual a medida da diagonal maior?");
            if (double.TryParse(Console.ReadLine(), out double baseMenor) == false || baseMenor <= 0)
            { Console.WriteLine("Insira um valor válido"); }
            else
            {
                Console.WriteLine("Qual a medida da altura?");
                if (double.TryParse(Console.ReadLine(), out double alturaTrapezio) == false || alturaTrapezio <= 0)
                { Console.WriteLine("Insira um valor válido"); }
                else
                {
                    Console.WriteLine("Qual a medida do lado um?");
                    if (double.TryParse(Console.ReadLine(), out double ladoUm) == false || ladoUm <= 0)
                    { Console.WriteLine("Insira um valor válido"); }
                    else
                    {
                        Console.WriteLine("Qual a medida do lado dois?");
                        if (double.TryParse(Console.ReadLine(), out double ladoDois) == false || ladoDois <= 0)
                        { Console.WriteLine("Insira um valor válido"); }
                        else
                        {
                            Console.WriteLine("Qual a medida do lado três?");
                            if (double.TryParse(Console.ReadLine(), out double ladoTres) == false || ladoTres <= 0)
                            { Console.WriteLine("Insira um valor válido"); }
                            else
                            {
                                Console.WriteLine("Qual a medida do lado quatro?");
                                if (double.TryParse(Console.ReadLine(), out double ladoQuatro) == false || ladoQuatro <= 0)
                                { Console.WriteLine("Insira um valor válido"); }
                                else
                                {
                                    var trapezio = new Trapezio(baseMaior, baseMenor, alturaTrapezio, ladoUm, ladoDois, ladoTres, ladoQuatro);
                                    Console.WriteLine(trapezio.ToString());
                                }
                            }
                        }
                    }
                }
            }
        }
        break;
}
