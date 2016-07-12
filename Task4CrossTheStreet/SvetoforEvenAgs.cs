using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4CrossTheStreet
{
    class SvetoforEvenAgs:EventArgs
    {
       
        public string Msg
        {
            get;
            protected set;
        }
        public string CurrLight
        {
            get;
            protected set;
        }
        public SvetoforEvenAgs(string color)
        {
            CurrLight = color;
            Msg = "It's " + CurrLight + " now!!!";
        }
    }
}
