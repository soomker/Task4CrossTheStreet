using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4CrossTheStreet
{
    class Program
    {
        static void Main(string[] args)
        {
            Svetofor svetofor = new Svetofor();
            Human bill = new Human("Bill");
            Human jeff = new Human("Jeff");
            Human andy = new Human("Andy");
            BadHuman badBill = new BadHuman("Bad Bill");
            BadHuman badJeff = new BadHuman("Bad Jeff");
            BadHuman badAndy = new BadHuman("Bad Andy");
            List<Human> humans = new List<Human> {bill,jeff,andy, badBill, badJeff , badAndy };
            svetofor.OnLightChanged += ShowCurrentLight;
            foreach (Human hum in humans)
            {
                svetofor.OnLightChanged += hum.HumanAction;
                hum.OnHumanAction += svetofor.VideoCamera.FillStatistic;
            }
            ConsoleKeyInfo key;
            Console.WriteLine("To Start Svetofor Press ENTER. To Stop press ESCAPE. To show Full Stat Press SPACEBAR.To show stat by light color press Q");
            Console.WriteLine();
            while (true)
            {
                switch ((key = Console.ReadKey()).Key)
                {
                    case (ConsoleKey.Enter):
                    svetofor.StartSvetofor();
                        break;

                    case (ConsoleKey.Escape):
                    svetofor.StopSvetofor();
                        Console.WriteLine();
                        Console.WriteLine("To show Full Stat Press SPACEBAR. To show stat by light color press Q");
                        break;

                    case (ConsoleKey.Spacebar):
                    svetofor.StopSvetofor();
                        Console.WriteLine();
                        Console.WriteLine(svetofor.VideoCamera.GetStatistic());
                        break;

                    case (ConsoleKey.Q):
                        svetofor.StopSvetofor();
                        Console.WriteLine("TYPE COLOR:");
                        Console.WriteLine(svetofor.VideoCamera.GetStatistic(Console.ReadLine()));
                        break;
                }
            }           
        }
      private  static void ShowCurrentLight(object sender, SvetoforEvenAgs e)
        {
            Console.WriteLine();
            Console.WriteLine(e.Msg);
        }
    }
}
