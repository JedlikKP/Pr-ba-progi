using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace próba_megint
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Random gép = new Random();
                char[,] pálya = new char[10, 10];
                int sor = 0, oszlop = 0;
                feltöltő(pálya);
                kirajzoló(pálya);

                Console.ReadKey();

            }

            private static void kirajzoló(char[,] pálya)
            {
                for (int sor = 0; sor < pálya.GetLength(0); sor++)
                {
                    for (int oszlop = 0; oszlop < pálya.GetLength(1); oszlop++)
                    {
                        Console.WriteLine($"{pálya[sor, oszlop]}|");
                    }
                    Console.WriteLine();
                }
            }

            private static void feltöltő(char[,] pálya)
            {
                for (int sor = 0; sor < pálya.GetLength(0); sor++)
                {
                    for (int oszlop = 0; oszlop < pálya.GetLength(1); oszlop++)
                    {
                        Console.WriteLine(pálya[sor, oszlop] = '_');
                    }

                }
            }
        }
    }
}
