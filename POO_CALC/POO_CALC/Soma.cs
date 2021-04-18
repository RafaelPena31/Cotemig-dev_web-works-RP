using System;
using System.Collections.Generic;
using System.Text;

namespace POO_CALC
{
    class Soma
    {
        private List<double> calcList;
        public Soma() { }
        public Soma(List<double> calcList)
        {
            this.CalcList = calcList;
        }

        public List<double> CalcList { get => calcList; set => calcList = value; }
        public double Somar()
        {
            double result = 0;
            foreach(double item in CalcList)
            {
                result += item;
            }
            return result;
        }
    }
}
