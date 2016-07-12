using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4CrossTheStreet
{
    class Human
    {
       private string name;
        public event EventHandler<HumanActionEventArgs> OnHumanAction;
        public string Name
        {
            get { return name; }
        }
        public Human(string humanName)
        {
            name = humanName;
        }

        public virtual void HumanAction(object sender, SvetoforEvenAgs e)
        {
            switch (e.CurrLight)
            {
                case "Red":
                    Wait(e.CurrLight);
                    break;
                case "Yellow":
                    GetReady(e.CurrLight);
                    break;
                case "Green":
                    Go(e.CurrLight);
                    break;

            }
        }

       protected void Go(string light)
        {
            // Console.WriteLine(e.CurrLight);
            OnHumanAction(this, new HumanActionEventArgs(light, DateTime.Now));
            Console.WriteLine("I'm " + name + " and i'm going!!!");
            
        }

        protected void Wait(string light)
        {
            Console.WriteLine("I'm " + name + " and i'm waiting!!!");
        }

        protected void GetReady(string light)
        {
            Console.WriteLine("I'm " + name + " and i'm get ready!!!");
        }
    }
}
