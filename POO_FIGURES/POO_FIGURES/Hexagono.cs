using System;
using System.Collections.Generic;
using System.Text;

namespace POO_FIGURES
{
    class Hexagono: Figura, IControle, ISuperficie
    {
        private double y;
        public Hexagono() { }
        public Hexagono(double x, double y): base(x) {
            this.Y = y;
        }

        public double Y { get => y; set => y = value; }

        public override double CalcularArea()
        {
            return (3*Math.Pow(X, 2)*Math.Sqrt(3))/2;
        }
        public string Desenhar()
        {
            return "Você precisará colorir uma área de: " + CalcularArea();
        }
        public string Pintar()
        {
            return "Você precisará traçar uma perímetro de: " + CalcularPerimetro(6);
        }
        public override string ToString()
        {
            return base.ToString() + Desenhar() + "\n" + Pintar();
        }

    }
}
