﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategypettern
{
    class PaprastaKaina : KainosIvertinimas
    {
        public float ivertintiKaina(int trukmeMenesiais)
        {
            if (trukmeMenesiais < 10)
            {
                return trukmeMenesiais * 7000;
            }
            else return trukmeMenesiais * 5000;
        }
    }
}
