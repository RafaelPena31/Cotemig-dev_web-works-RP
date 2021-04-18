using System;
using System.Collections.Generic;
using System.Text;

namespace POO_FIGURES
{
    class Quadrado: Figura, IControle, ISuperficie
    {
        public Quadrado() { }
        public Quadrado(double x) : base(x)
        {

        }
        public override double CalcularArea()
        {
            return (X * X);
        }
        public string Desenhar()
        {
            return "Você precisará colorir uma área de: " + CalcularArea();
        }
        public string Pintar()
        {
            return "Você precisará traçar uma perímetro de: " + CalcularPerimetro(4);
        }
        public override string ToString()
        {
            return base.ToString() + Desenhar() + "\n" + Pintar();
        }
    }
}
