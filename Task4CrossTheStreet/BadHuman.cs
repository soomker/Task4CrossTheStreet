using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4CrossTheStreet
{
    class BadHuman:Human
    {
        public BadHuman(string name):base(name)
        {
        }
        public override void HumanAction(object sender, SvetoforEvenAgs e)
        {
            switch (e.CurrLight)
            {
                case "Red":
                    Go(e.CurrLight);
                    break;
                case "Yellow":
                    Go(e.CurrLight);
                    break;
                case "Green":
                    Wait(e.CurrLight);
                    break;

            }
        }
    }
}
