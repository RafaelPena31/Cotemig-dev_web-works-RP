using System;
using System.Collections.Generic;
using System.Text;

namespace POO_ANIMAIS
{
    class Baleia:Mamifero
    {
        public Baleia() { }
        public Baleia(string nome): base(nome)
        {

        }
        public void Nadar()
        {
            Console.WriteLine("Animal nadou!");
        }
    }
}
