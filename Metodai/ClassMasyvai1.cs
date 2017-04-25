using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodai
{
   public class ClassMasyvai1
    {
        public void masyvas1() {

            int[] skaiciai = new int[5];
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iveskite skacius");
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var skaicius in skaiciai)
            {
                Console.WriteLine(skaicius + " ");
            }
            //Console.WriteLine();

            string[] zodziai = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iveskite zodi");
                zodziai[i] = Console.ReadLine();
            }
            foreach (var zodis in zodziai)
            {
                Console.WriteLine(zodis + " ");
            } 
        }
    }
}
