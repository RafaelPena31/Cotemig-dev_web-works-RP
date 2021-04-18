using System;
using System.Collections.Generic;
using System.Text;

namespace POO_FIGURES
{
    class Equilatero:Figura, IControle, ISuperficie
    {
        private double y;
        public Equilatero() { }
        public Equilatero(double x, double y): base(x)
        {
            this.Y = y;
        }

        public double Y { get => y; set => y = value; }
        public override double CalcularArea()
        {
            return (X * Y) / 2;
        }
        public string Desenhar()
        {
            return "Você precisará colorir uma área de: " + CalcularArea();
        }
        public string Pintar()
        {
            return "Você precisará traçar uma perímetro de: " + CalcularPerimetro(3);
        }
        public override string ToString()
        {
            return base.ToString() + Desenhar() + "\n" + Pintar();
        }
    }
}
