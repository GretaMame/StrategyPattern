using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategypettern
{
    class Program
    {
        static void Main(string[] args)
        {
            Namas namas1 = new Namas(new MedninisStatymas(), new PaprastaKaina(), 12);
            Namas namas2 = new Namas(new MurinisStatymas(), new KainaSuNuolaida(), 14);
            Restoranas restoranas = new Restoranas(new MurinisStatymas());

            namas1.gautiKaina();
            namas1.pastatytiNama();
            Console.WriteLine();
            namas2.gautiKaina();
            namas2.pastatytiNama();
            Console.WriteLine();
            restoranas.pastatytiRestorana();
            Console.ReadLine();

        }
    }
}
