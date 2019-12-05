using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 100);
            Console.Write("x=");
            int x = Convert.ToInt32(Console.ReadLine());
            int flag = 0;

            while (flag == 0)
            {

                if (x < number)
                {
                    Console.WriteLine("Numarul introdus este prea mic. Incearca un numar mai mare.");
                    Console.Write("x=");
                    x = Convert.ToInt32(Console.ReadLine());
                }
                else if (x > number)
                {
                    Console.WriteLine("Numarul introdus este prea mare. Incearca un numar mai mic");
                    Console.Write("x=");
                    x = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Felicitari, ai ghicit numarul");
                    flag = 1;
                }
            }
        }
    }
}
