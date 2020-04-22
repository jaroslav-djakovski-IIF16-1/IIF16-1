﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_3_4
{
    class FileLinkedList
    {

        public static void studSplit(LinkedList<studentas> studentai)
        {

            File.Create(@"d:\Geresni.txt").Close();
            File.Create(@"d:\Blogesni.txt").Close();
            int count = 0;
            using (StreamWriter ger = new StreamWriter(@"d:\Geresni.txt"))
            {
                using (StreamWriter bl = new StreamWriter(@"d:\Blogesni.txt"))
                {
                    ger.WriteLine(String.Format("{0,-15} {1,-15} {2,-15} {3,25}", "Vardas", "Pavardė", "Galutinis (vid.)", "Galutinis (med.)"));
                    foreach (var student in studentai)
                    {
                        if (student.vidurkis > 5)
                        {
                            ger.WriteLine(String.Format("{0,-15} {1,-25} {2, -25} {3, 0}", student.vardas, student.pavarde, Math.Round(student.vidurkis, 2), student.mediana));
                        }
                        else
                        {
                            if (count == 0)
                            {
                                bl.WriteLine(String.Format("{0,-15} {1,-15} {2,-15} {3,25}", "Vardas", "Pavardė", "Galutinis (vid.)", "Galutinis (med.)"));
                                bl.WriteLine(String.Format("{0,-15} {1,-25} {2, -25} {3, 0}", student.vardas, student.pavarde, Math.Round(student.vidurkis, 2), student.mediana));
                                count++;
                            }
                            else
                                bl.WriteLine(String.Format("{0,-15} {1,-25} {2, -25} {3, 0}", student.vardas, student.pavarde, Math.Round(student.vidurkis, 2), student.mediana));

                        }
                    }
                }

            }
        }

        public static void linkedlist()
        {

            LinkedList<studentas> studentai = new LinkedList<studentas>();
            int counter = 0;
            int[] paz = new int[10];
            string line;
            double vid = 0, med = 0;
            StreamReader stud = null;
            Console.WriteLine("Iveskite failo direktorija: ");
            string dirPath = @"" + Console.ReadLine();
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            try
            {
                stud = new StreamReader(dirPath);
            }
            catch
            {
                Console.WriteLine("Blogai ivesta failo direktorija. Bandykite is naujo. (Press any key to continue.)");
                Console.ReadLine();
                linkedlist();
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

                    studentai.AddLast(new studentas { vardas = words[0], pavarde = words[1], vidurkis = vid, mediana = med });
                    counter++;

                }
                else
                    counter++;

            }
            stud.Close();
            watch1.Stop();
            double laikas1 = watch1.ElapsedMilliseconds;
            double sekundes1 = laikas1 / 1000;
            Console.WriteLine("Duomenys suskaičiavo per: " + sekundes1 + " sekundziu");
            Console.WriteLine("Ar norite pamatyti duomenys ekrane? (Parašykite 'taip' jei norite juos pamatyti)");
            string check = Console.ReadLine();

            if (check == "taip")
            {
                string s = new String('-', 80);
                Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-15} {3,25}", "Vardas", "Pavardė", "Galutinis (vid.)", "Galutinis (med.)"));
                Console.WriteLine(s);
                foreach (var student in studentai)
                {
                    Console.WriteLine(String.Format("{0,-15} {1,-25} {2, -25} {3, 0}", student.vardas, student.pavarde, Math.Round(student.vidurkis, 2), student.mediana));
                }
                Console.WriteLine(s);
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();
            studSplit(studentai);
            watch.Stop();
            double laikas = watch.ElapsedMilliseconds;
            double sekundes = laikas / 1000;
            Console.WriteLine("Duomenys i failus padalino per: " + sekundes + " sekundziu");
            Console.WriteLine("");
            Console.WriteLine("išviso programa dirbo: " + (sekundes + sekundes1) + " sekundziu");
            Console.ReadLine();
            Program.menu();
        }

    }
}
