using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategypettern
{
    class Restoranas
    {
        Statymas sb;

        public Restoranas(Statymas statymoBudas)
        {
            sb = statymoBudas;
        }

        public void pastatytiRestorana()
        {
            Console.WriteLine("1 etapas: {0}", sb.islietiPamatus());
            Console.WriteLine("2 etapas: {0}", sb.pastatytiSienas());
            Console.WriteLine("3 etapas: {0}", sb.uzdengtiStoga());
        }
    }
}
