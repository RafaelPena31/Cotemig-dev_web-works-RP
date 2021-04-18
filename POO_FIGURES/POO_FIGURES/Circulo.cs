using System;
using System.Collections.Generic;
using System.Text;

namespace POO_FIGURES
{
    class Circulo: Figura, IControle, ISuperficie
    {
        public Circulo() { }
        public Circulo(double x): base(x)
        {

        }
        public override double CalcularArea()
        {
            return 3.14 * Math.Pow(X, 2);
        }
        public double CalcularPerimetroCirculo()
        {
            return 2 * 3.14 * X;
        }
        public string Desenhar()
        {
            return "Você precisará colorir uma área de: " + CalcularArea();
        }
        public string Pintar()
        {
            return "Você precisará traçar uma perímetro de: " + CalcularPerimetroCirculo();
        }
        public override string ToString()
        {
            return base.ToString() + Desenhar() + "\n" + Pintar();
        }
    }
}
