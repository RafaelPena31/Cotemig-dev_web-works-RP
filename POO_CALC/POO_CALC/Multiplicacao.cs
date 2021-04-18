using System;
using System.Collections.Generic;
using System.Text;

namespace POO_CALC
{
    class Multiplicacao
    {
        private List<double> calcList;
        public Multiplicacao() { }
        public Multiplicacao(List<double> calcList)
        {
            this.CalcList = calcList;
        }

        public List<double> CalcList { get => calcList; set => calcList = value; }
        public double Multiplicar()
        {
            double result = CalcList[0];
            int index = 0;
            foreach (double item in CalcList)
            {
                if (index == 0)
                {
                    index++;
                    continue;
                }
                else
                {
                    result *= item;
                    index++;
                }
            }
            return result;
        }
    }
}
