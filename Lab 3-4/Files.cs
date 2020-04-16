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
    class Files
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
            try
            {
                stud = new StreamReader(dirPath);
            }
            catch {
                Console.WriteLine("Blogai ivesta failo direktorija. Bandykite is naujo. (Press any key to continue.)");
                Console.ReadLine();
                file();
            }
            while ((line = stud.ReadLine()) != null)
            {
                string[] words = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                if (counter != 0)
                {
                    for (int i = 2; i <= 7; i++)
                    {
                        try
                        {
                            vid = vid + Convert.ToInt32(words[i]);
                        }
                        catch
                        {
                            Console.WriteLine("Blogai ivesti studento pazymiai faile. Bandykite is naujo. (Press any key to continue.)");
                            Console.ReadLine();
                            Program.menu();
                        }
                    }
                    vid = vid / 6;
                    try
                    {
                        vid = (0.3 * vid) + (0.7 * Convert.ToInt32(words[8]));
                    }
                    catch
                    {
                        Console.WriteLine("Blogai ivesti studento egzamino pazymiai faile. Bandykite is naujo. (Press any key to continue.)");
                        Console.ReadLine();
                        Program.menu();
                    }

                    for (int i = 2; i <= 7; i++)
                    {

                        paz[i - 2] = Convert.ToInt32(words[i]);
                    }
                    Array.Sort(paz);

                    med = (paz[2] + paz[3]) / 2;

                    med = (0.3 * med) + (0.7 * Convert.ToInt32(words[8]));

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
