using System;
using System.Collections.Generic;

namespace POO_CALC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita - nº 46 - 11901322");

            Console.WriteLine("Qual operação você gostaria de realizar? \n Digite o operador correspondente: \n- Adição: + \n- Subtração: - \n- Multiplicação: * \n- Divisão: /");
            char operatorFunc = char.Parse(Console.ReadLine());

            int switchOnOff = 1;
            List<double> result = new List<double>();
            while (switchOnOff == 1)
            {
                Console.WriteLine("Digite um número para adicionar ao cálculo:");
                result.Add(double.Parse(Console.ReadLine()));
                if (result.Count < 2)
                {
                    Console.WriteLine("Digite o próximo número para adicionar ao cálculo:");
                    result.Add(double.Parse(Console.ReadLine()));
                }
                Console.WriteLine("Caso não queira adicionar mais nenhum número, digite 0, se não, digite 1:");
                switchOnOff = int.Parse(Console.ReadLine());
            }

            string printResult = "";

            switch (operatorFunc)
            {
                case '+':
                    Soma somaOperatorClass = new Soma(result);
                    printResult = "O resultado da operação é: " + somaOperatorClass.Somar();
                        break;
                case '-':
                    Subtracao subtracaoOperatorClass = new Subtracao(result);
                    printResult = "O resultado da operação é: " + subtracaoOperatorClass.Subtraia();
                    break;
                case '*':
                    Multiplicacao multiplicacaoOperatorClass = new Multiplicacao(result);
                    printResult = "O resultado da operação é: " + multiplicacaoOperatorClass.Multiplicar();
                    break;
                case '/':
                    Divisao divisaoOperatorClass = new Divisao(result);
                    printResult = "O resultado da operação é: " + divisaoOperatorClass.Dividir();
                    break;
                default:
                    Console.WriteLine("Operador inválido!");
                    Console.ReadKey();
                    break;
            }

            Console.WriteLine(printResult);
            
            Console.ReadKey();
        }
    }
}
