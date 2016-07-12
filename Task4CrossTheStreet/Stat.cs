using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4CrossTheStreet
{
    class Stat
    {
        public Human Human 
          {
            get;
            protected set;
          }
        public DateTime Date
        {
            get;
            protected set;
        }

        public string Light { get; private set; }
        public Stat(Human hum, DateTime date, string light)
        {
            Human = hum;
            Date = date;
            Light = light;
        }
    }
}
