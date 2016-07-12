using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4CrossTheStreet
{
    class HumanActionEventArgs:EventArgs
    {
        public string SvetoforLight
        {
            get;
            protected set;
        }

        public DateTime Date
        {
            get;
            protected set;
        }

        public HumanActionEventArgs(string light, DateTime dateTime)
        {
            SvetoforLight = light;
            Date = dateTime;
        }
    }
}
