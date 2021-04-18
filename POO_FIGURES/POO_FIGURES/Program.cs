using System;

namespace POO_FIGURES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita - nº: 46 - 11901322\n\n\n\n");
            Equilatero triangulo = new Equilatero(3, 4);
            Quadrado quadrado = new Quadrado(4);
            Circulo circulo = new Circulo(3);
            Pentagono pentagono = new Pentagono(3, 4);
            Hexagono hexagono = new Hexagono(3, 4);

            Console.WriteLine("Triângulo - " + triangulo.ToString());
            Console.WriteLine("Quadrado - " + quadrado.ToString());
            Console.WriteLine("Circulo - " + circulo.ToString());
            Console.WriteLine("Pentagono - " + pentagono.ToString());
            Console.WriteLine("Hexagono - " + hexagono.ToString());

            Console.ReadKey();
        }
    }
}
