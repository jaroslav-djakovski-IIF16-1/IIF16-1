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

            Console.WriteLine("Norite duomenys nuskaityti is failo ar ivesite ranka? (iveskite 'file' ar 'ranka'). Jei norite uzdaryti programa parasykite 'exit' ");
            string a = Console.ReadLine();
            a = a.ToLower();
            switch (a)
            {
                case "file":
                    File.file();
                    break;
                case "ranka":
                    Ranka.ranka();
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("Blogas pasirinkimas");
                    menu();
                    break;
            }

        }
        static void Main(string[] args)
        {
            menu();
        }
    }
}
