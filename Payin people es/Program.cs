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
            int n;
            Console.Write("Insert the number of consultants: ");

            while (!int.TryParse(Console.ReadLine(), out n)) ;

            int[] settimane = new int[n], paga = new int[n];
            string[] nomi_consulenti = new string[n];
            //The name of the consultant is inserted
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Insert the number of consultant n°{i}: ");
                nomi_consulenti[i] = Console.ReadLine();
            }
            //The pay for the consultant is inserted
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write($"Insert he pay of consultant {nomi_consulenti[i]}: ");
                } while (!int.TryParse(Console.ReadLine(), out paga[i]));
            }
            //Get in the input how many weeks they worked
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write($"Insert how many weeks {nomi_consulenti[i]} worked: ");
                } while (!int.TryParse(Console.ReadLine(), out settimane[i]));
            }
            //Checks if they had 4 weeks of work and gives extra cash if so
            for (int i = 0; i < n; i++)
            {
                if (settimane[i] >= 4)
                {
                    paga[i] += paga[i] / 2;
                }
                Console.WriteLine($"The pay of {nomi_consulenti[i]} is {paga[i]}");
            }

            Console.ReadKey();
        }
    }
}
