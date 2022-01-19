using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payin_people_es
{
    class Program
    {
        static void Main(string[] args)
        {
            bool extra_paga = false;
            int n;
            Console.WriteLine("Inserire il numero di consulenti");
            do
            {

            } while (!int.TryParse(Console.ReadLine(), out n));
            int[] settimane = new int[n], paga = new int[n];
            string[] nomi_consulenti = new string[n];
            //The name of the consultant is inserted
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Inserire il nome del consolente (n°{i})");
                nomi_consulenti[i] = Console.ReadLine();
            }
            //The pay for the consultant is inserted
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine($"Inserire la paga del consolente {nomi_consulenti[i]}");
                } while (!int.TryParse(Console.ReadLine(), out paga[i]));
            }
            //Get in the input how many weeks they worked
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine($"Inserire quante settimane ha lavorato il consolente {nomi_consulenti[i]}");
                } while (!int.TryParse(Console.ReadLine(), out settimane[i]));
            }
            //Checks if they had 4 weeks of work and gives extra cash if so
            for (int i = 0; i < n; i++)
            {
                if (settimane[i] < 4)
                {
                    extra_paga = false;
                }
                else
                {
                    extra_paga = true;
                    paga[i] += paga[i] / 2;
                }
                Console.WriteLine($"La paga di {nomi_consulenti[i]} è {paga[i]}");
            }

            Console.ReadKey();
        }
    }
}
