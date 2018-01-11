using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategypettern
{
    class Namas
    {
        Statymas sb;
        KainosIvertinimas ki;
        private float kaina;
        private int statymoTrukmeMenesiais;

        public Namas(Statymas statymoBudas, KainosIvertinimas ki, int trukme)
        {
            sb = statymoBudas;
            this.ki = ki;
            statymoTrukmeMenesiais = trukme;
        }

        public void pastatytiNama()
        {
            Console.WriteLine(sb.islietiPamatus());
            Console.WriteLine(sb.pastatytiSienas());
            Console.WriteLine(sb.uzdengtiStoga());
        }

        public void gautiKaina()
        {
            kaina = ki.ivertintiKaina(statymoTrukmeMenesiais);
            Console.WriteLine("Statymo kaina: {0}", kaina);
        }
    }
}
