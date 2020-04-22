using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_3_4
{
    class Program
    {
        public static void menu()
        {

            Console.WriteLine("Norite duomenys nuskaityti iš failo ar ivesite ranka? (iveskite 'file' ar 'ranka')");
            Console.WriteLine("Ar norite sugeneruoti atsitiktinius duomenys? (iveskite 'generate').");
            Console.WriteLine("Jei norite uzdaryti programa parašykite 'exit' ");
            string a = Console.ReadLine();
            a = a.ToLower();
            switch (a)
            {
                case "file":
                    choose();
                    break;
                case "ranka":
                    Ranka.ranka();
                    break;
                case "generate":
                    generate();
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("Blogas pasirinkimas");
                    menu();
                    break;
            }

        }

        public static void choose()
        {
            Console.WriteLine(" List / LinkedList / Queue ");
            string a = Console.ReadLine();
            a = a.ToLower();
            switch (a)
            {
                case "list":
                    Files.list();
                    break;
                case "linkedlist":
                    FileLinkedList.linkedlist();
                    break;
                case "queue":
                    FileQueue.queue();
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("Blogas pasirinkimas");
                    choose();
                    break;
            }

        }

        public static void generate() {

            Random rnd = new Random();
            int nr = 0;
            string vard, pav;
            Console.WriteLine("Iveskite failo direktorija ir pavadinima: ");
            string dirPath = @"" + Console.ReadLine();
            if (File.Exists(dirPath))
            {
                File.Delete(dirPath);
            }
            File.Create(dirPath).Close();
            Console.WriteLine("Iveskite kiek skirtingu duomenu bus faile: ");
            nr = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter writer = new StreamWriter(dirPath))
            {
                writer.WriteLine(String.Format("{0,-15} {1,-15} {2,-5} {3,-5} {4,-5} {5,-5} {6,-5} {7,-5} {8,5}", "Vardas", "Pavardė", "ND1", "ND2", "ND3", "ND4", "ND5", "ND6", "Egz."));
                for (int i = 1; i <= nr; i++)
                {
                    int[] b = new int[10];
                    for (int j = 0; j < 7; j++)
                    {
                        b[j] = rnd.Next(2, 11);
                    }
                    vard = "Vardas" + Convert.ToString(i);
                    pav = "Pavardė" + Convert.ToString(i);
                    writer.WriteLine(String.Format("{0,-15} {1,-15} {2,-5} {3,-5} {4,-5} {5,-5} {6,-5} {7,-5} {8,5}", vard, pav, b[0], b[1], b[2], b[3], b[4], b[5], b[6]));
                }

            }

            Console.WriteLine("Duomenys sugeneruoti. (Press any key to continue.)");
            Console.ReadLine();

            menu();

        }
        static void Main(string[] args)
        {
            menu();
        }
    }
}
