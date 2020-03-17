using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_4
{
    class Program
    {
        public static void Galutinis()
        {

        }
        static void Main(string[] args)
        {
            string vard;
            string [] vardas = new string[10000];
            string [] pavarde = new string[10000];
            double [] galutinis = new double [10000];
            int a=0, egz;
            double vid=0;

            Console.WriteLine("Iveskite studentu skaiciu ");
            int studsk = Convert.ToInt32(Console.ReadLine());
            while (studsk > 0) {
                Console.WriteLine("Iveskite studento vardą ir pavardę. ");
                vard = Console.ReadLine();
                string[] split = vard.Split(' ');
                vardas[a] = split[0];
                pavarde[a] = split[1];
                Console.WriteLine("iveskite studento pazymius. ");
                string p = Console.ReadLine();
                split = p.Split(' ');
                int[] pazymiai = Array.ConvertAll(split, int.Parse);
                foreach (int paz in pazymiai)
                {
                    vid = vid + paz;
                }
                vid = vid / pazymiai.Length;
                Console.WriteLine("iveskite studento egzamino pazymi. ");
                egz = Convert.ToInt32(Console.ReadLine());
                galutinis [a] = (0.3 * vid) + (0.7 * egz);
                a++;
                studsk--;
                vid = 0;
            }

            string s = new String('-', 50);
            Console.WriteLine(String.Format("{0,-15} {1,-15} {2,5}", "Vardas", "Pavardė", "Galutinis (Vid.)"));
            Console.WriteLine(s);
            for (int i = 0; i < 2; i++) {

                Console.WriteLine(String.Format("{0,-15} {1,-25} {2:0.00}", vardas[i], pavarde[i], galutinis[i])) ;

            }
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
