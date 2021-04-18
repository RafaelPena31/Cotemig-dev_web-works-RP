using System;
using System.Collections.Generic;
using System.Text;

namespace POO_FIGURES
{
    abstract class Figura
    {
        private double x;
        public Figura() { }
        public Figura(double x)
        {
            this.X = x;
        } 

        public double X { get => x; set => x = value; }
        public abstract double CalcularArea();

        public double CalcularPerimetro(int sides)
        {
            return X * sides;
        }

        public override string ToString()
        {
            return "Informações do desenho: \n\n";
        }

    }
}
