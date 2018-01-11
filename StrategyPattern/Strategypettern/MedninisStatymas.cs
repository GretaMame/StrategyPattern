﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategypettern
{
    class MedninisStatymas : Statymas
    {
        public string islietiPamatus()
        {
            return "Islieti mediniam statiniui tinkami pamatai.";
        }

        public string pastatytiSienas()
        {
            return "Pastatytos medines sienos.";
        }

        public string uzdengtiStoga()
        {
            return "Uzdengtas medinis stogas.";
        }
    }
}
