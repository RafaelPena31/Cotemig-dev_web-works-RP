using System;

namespace POO_ANIMAIS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rafael Augusto Pena Pereira Mesquita - nº 46 - 11901322");

            var baleia = new Baleia("Thomas");
            baleia.Comer();
            baleia.Dormir();
            baleia.Acordar();
            baleia.Nadar();
            baleia.Mamar();

            var morcego = new Morcego("James");
            morcego.Comer();
            morcego.Dormir();
            morcego.Acordar();
            morcego.Voar();
            morcego.Mamar();
        }
    }
}
