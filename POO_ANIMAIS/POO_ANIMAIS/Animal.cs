using System;
using System.Collections.Generic;
using System.Text;

namespace POO_ANIMAIS
{
    class Animal
    {
        private string nome;
        public Animal() { }
        public Animal(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get => nome; set => nome = value; }
        public void Acordar()
        {
            Console.WriteLine("Animal acordou!");
        }

        public void Dormir()
        {
            Console.WriteLine("Animal dormiu!");
        }

        public void Comer()
        {
            Console.WriteLine("Animal comeu!");
        }
    }
}
