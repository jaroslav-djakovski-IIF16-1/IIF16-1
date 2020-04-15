using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_3_4
{
    struct studentas
    {
        public string vardas;
        public string pavarde;
        public double vidurkis;
        public double mediana;
    }
    class File
    {
        public static void file()
        {

            List<studentas> studentai = new List<studentas>();
            int counter = 0;
            int[] paz = new int[10];
            string line;
            double vid = 0, med = 0;
            StreamReader stud = null;
            Console.WriteLine("Iveskite failo direktorija: ");
            string dirPath = @"" + Console.ReadLine();
            stud = new StreamReader(dirPath);
            while ((line = stud.ReadLine()) != null)
            {
                string[] words = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                if (counter != 0)
                {
                    for (int i = 2; i <= 7; i++)
                    {

                        vid = vid + Convert.ToInt32(words[i]);
                    }
                    vid = vid / 6;
                    vid = (0.3 * vid) + (0.7 * Convert.ToInt32(words[7]));

                    for (int i = 2; i <= 7; i++)
                    {

                        paz[i - 2] = Convert.ToInt32(words[i]);
                    }
                    Array.Sort(paz);

                    med = (paz[2] + paz[3]) / 2;

                    med = (0.3 * med) + (0.7 * Convert.ToInt32(words[7]));

                    studentai.Add(new studentas { vardas = words[0], pavarde = words[1], vidurkis = vid, mediana = med });
                    counter++;

                }
                else
                    counter++;

            }
            stud.Close();

            studentai.Sort((x, y) => string.Compare(x.pavarde, y.pavarde));
            studentai.Sort((x, y) => string.Compare(x.vardas, y.vardas));
            string s = new String('-', 80);
            Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-15} {3,25}", "Vardas", "Pavardė", "Galutinis (vid.)", "Galutinis (med.)"));
            Console.WriteLine(s);
            foreach (var student in studentai)
            {
                Console.WriteLine(String.Format("{0,-15} {1,-25} {2, -25} {3, 0}", student.vardas, student.pavarde, Math.Round(student.vidurkis, 2), student.mediana));
            }
            Console.WriteLine(s);
            Console.ReadLine();
            Program.menu();
        }

    }
}
