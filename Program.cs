using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pppzv7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi broj: ");

            int broj = Convert.ToInt32(Console.ReadLine());

            if (broj % 4 == 0 && broj % 6 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 4 i sa 6.");
                Console.ReadKey();
                return;
            }
            if (broj % 6 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 6.");
                Console.ReadKey();
                return;
            }
            if (broj % 4 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 4.");
                Console.ReadKey();
                return;
            }

            if (broj % 4 >= 1 && broj % 6 >= 1)
            {
                Console.WriteLine("Broj nije djeljiv sa 4 ni sa 6.");
                Console.ReadKey();
                return;
            }

        }
    }
}
