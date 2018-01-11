﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategypettern
{
    class MurinisStatymas : Statymas
    {
        public string islietiPamatus()
        {
            return "Islieti muriniam statiniui tinkami pamatai.";
        }

        public string pastatytiSienas()
        {
            return "Pastatytos sienos is plytu.";
        }
        public string uzdengtiStoga()
        {
            return "Uzdengtas stogas is cerpiu.";
        }
    }
}
