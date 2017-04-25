using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodai
{
    class Program
    {
        static void Main(string[] args)
        {

            //ClassMasyvai1 mas = new ClassMasyvai1();
            //mas.masyvas1();
            //Console.WriteLine();

            //Console.WriteLine("Iveskite du skaicius");
            //var a = Convert.ToInt32(Console.ReadLine());
            //var b = Convert.ToInt32(Console.ReadLine());

            //ClassMet2 skaiciavimai = new ClassMet2();
            //var suma = skaiciavimai.SumMet(a, b);
            //Console.WriteLine(suma);

            //ClassMet2 atimtis = new ClassMet2();
            //var atimti = atimtis.SkirtMet(a, b);
            //Console.WriteLine(atimti);

            //ClassMet2 Dalyba = new ClassMet2();
            //var dal = Dalyba.DalMet(a, b);
            //Console.WriteLine(dal);

            //ClassMet2 daugyba = new ClassMet2();
            //var daug = daugyba.DaugMet(a, b);
            //Console.WriteLine(daug);

            //ClassMet1 pasisveik = new ClassMet1();
            //pasisveik.pasisveikinimas();

            //metodas1();
            //Program p = new Program();
            //p.metodas2();

            int kiek;
            double svoris;
            int zkiekis;

            tikrinimas(out kiek);
            double[] svoriai = new double[kiek];
            int[] skoniai = new int[kiek];

            Ivedimas(svoriai, skoniai);
            skaiciavimas(svoriai, skoniai, out svoris, out zkiekis);
            spausdinimas(zkiekis, svoris);


        }

        private static void tikrinimas ( out int zuvuKiekis)
        {
            Console.WriteLine("Kiek zuvu ivesi");
            zuvuKiekis = Convert.ToInt32(Console.ReadLine());

            while (zuvuKiekis <= 0)
            {
                Console.WriteLine("Blogas skaicius, iveskite skaiciu didesni nei 0");
                zuvuKiekis = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static void Ivedimas(double[] svoriai, int[] skoniai)
        {
            for (int i = 0; i < svoriai.Length; i++)
            {
                Console.WriteLine("Iveskite svori");
                svoriai[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Iveskite skoni");
                Console.WriteLine("0 - neskanu, 1 - skanu");
                skoniai[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        private static void skaiciavimas(double [] mas1, int [] mas2, out double svoriuSuma, out int kiek)
        {
            svoriuSuma = 0;
            kiek = 0;
            for (int i = 0; i < mas1.Length; i++)
            {
                if (mas1[i]>1 && mas2[i] == 1)
                {
                    svoriuSuma += mas1[i];
                    kiek++;
                }
            }
        }

        private static void spausdinimas(int kiekis, double svoris) {

            Console.WriteLine("Katinas pasinese: " + kiekis +  "zuvu.");
            Console.WriteLine("Zuvu svoris" + svoris);

        }

        //public static void metodas1()
        //{
        //    Console.WriteLine("Hello world");
        //}

        //public void metodas2() {
        //    Console.WriteLine("Helloouu world");

        
        }
    }

