using System;
using System.Collections.Generic;
using System.Text;

namespace POO_FIGURES
{
    class Pentagono: Figura, IControle, ISuperficie
    {
        private double y;
        public Pentagono() { }
        public Pentagono(double x, double y): base(x) {
            this.Y = y;
        }

        public double Y { get => y; set => y = value; }

        public override double CalcularArea()
        {
            return (X*5) * Y;
        }
        public string Desenhar()
        {
            return "Você precisará colorir uma área de: " + CalcularArea();
        }
        public string Pintar()
        {
            return "Você precisará traçar uma perímetro de: " + CalcularPerimetro(5);
        }
        public override string ToString()
        {
            return base.ToString() + Desenhar() + "\n" + Pintar();
        }
    }
}
