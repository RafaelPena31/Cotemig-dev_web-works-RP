using System;
using System.Collections.Generic;
using System.Text;

namespace POO_ANIMAIS
{
    class Mamifero:Animal
    {
        public Mamifero() { }
        public Mamifero(string nome): base(nome)
        {

        }

        public void Mamar()
        {
            Console.WriteLine("Animal mamou!");
        }
    }
}
