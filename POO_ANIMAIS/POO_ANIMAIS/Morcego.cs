using System;
using System.Collections.Generic;
using System.Text;

namespace POO_ANIMAIS
{
    class Morcego:Mamifero
    {
        public Morcego() { }
        public Morcego(string nome): base(nome)
        {

        }
        public void Voar()
        {
            Console.WriteLine("Animal voou!");
        }

    }
}
