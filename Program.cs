using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_4
{
    class Program
    {
        public static void vidurkis(string[] a, int[] e, string[] vardas, string[] pavarde, int sk)
        {
            double vid = 0;
            double[] g = new double[10000];
            string ab;
            for (int i = 0; i < sk; i++)
            {
                ab = a[i];
                string[] paz = ab.Split(' ');
                int[] pazymiai = Array.ConvertAll(paz, int.Parse);
                foreach (int p in pazymiai)
                {
                    vid = vid + p;
                }
                vid = vid / pazymiai.Length;
                g[i] = (0.3 * vid) + (0.7 * e[i]);
                vid = 0;
            }
            string s = new String('-', 50);
            Console.WriteLine(String.Format("{0,-15} {1,-15} {2,5}", "Vardas", "Pavardė", "Galutinis (Vid.)"));
            Console.WriteLine(s);
            for (int i = 0; i < sk; i++)
            {

                Console.WriteLine(String.Format("{0,-15} {1,-25} {2:.##}", vardas[i], pavarde[i], g[i]));

            }
            Console.WriteLine(s);
            Console.ReadLine();
        }

        public static void mediana(string[] a, int[] e, string[] vardas, string[] pavarde, int sk)
        {
            double med;
            double[] g = new double[10000];

            for (int i = 0; i < sk; i++)
            {
                string ab = a[i];
                string[] paz = ab.Split(' ');
                int[] pazymiai = Array.ConvertAll(paz, int.Parse);
                Array.Sort(pazymiai);

                if (pazymiai.Length % 2 == 1)
                {
                    med = pazymiai[pazymiai.Length / 2];
                }
                else
                {
                    med = (pazymiai[(pazymiai.Length / 2) - 1] + pazymiai[(pazymiai.Length / 2)]);
                    med = med / 2;
                }
                g[i] = (0.3 * med) + (0.7 * e[i]);
            }

            string s = new String('-', 50);
            Console.WriteLine(String.Format("{0,-15} {1,-15} {2,5}", "Vardas", "Pavardė", "Galutinis (Med.)"));
            Console.WriteLine(s);
            for (int i = 0; i < sk; i++)
            {

                Console.WriteLine(String.Format("{0,-15} {1,-25} {2:.##}", vardas[i], pavarde[i], g[i]));

            }
            Console.WriteLine(s);
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            string vard;
            string[] vardas = new string[10000];
            string[] pavarde = new string[10000];
            string[] pazymiai = new string[10000];
            double[] galutinis = new double[10000];
            int[] egz = new int[10000];
            int a = 0;

            Console.WriteLine("Iveskite studentu skaiciu ");
            int studsk = Convert.ToInt32(Console.ReadLine());
            while (studsk > 0)
            {
                Console.WriteLine("Iveskite studento vardą ir pavardę. ");
                vard = Console.ReadLine();
                string[] split = vard.Split(' ');
                vardas[a] = split[0];
                pavarde[a] = split[1];
                Console.WriteLine("iveskite studento pazymius. ");
                pazymiai[a] = Console.ReadLine();
                Console.WriteLine("iveskite studento egzamino pazymi. ");
                egz[a] = Convert.ToInt32(Console.ReadLine());
                a++;
                studsk--;
            }
            Console.WriteLine("Pazymis skaiciuosite su mediana ar su vidurkiu? (iveskite 'mediana' ar 'vidurkis') ");
            string check = Console.ReadLine();

            if (check == "vidurkis")
                vidurkis(pazymiai, egz, vardas, pavarde, a);

            if (check == "mediana")
                mediana(pazymiai, egz, vardas, pavarde, a);


        }
    }
}
