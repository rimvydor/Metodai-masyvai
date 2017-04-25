using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodai
{
  public class ClassMet1
    {
        public void pasisveikinimas()
        {
            
            Console.WriteLine("Koks Jusu vardas");
            var vardas = Console.ReadLine();
            Console.WriteLine("Koks Jusu amzius");
            var amzius = Console.ReadLine();
            Console.WriteLine("Koks Jusu hobis");
            var hobis = Console.ReadLine();
            Console.WriteLine("Labas. " + vardas + " " + "(" + amzius + "m.).");
            Console.WriteLine("Tavo hobis yra: " + hobis);
        }

    }
}
