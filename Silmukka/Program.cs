using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silmukka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Ohjelma laskee kertoman. Anna luku, jonka kertoma lasketaan: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            int i = 0;
            double f = 1;
            if (number > 0)
            {
                do
                {
                    i++;
                    f *= i;
                    //f = f * i;
                } while (i < number);
                Console.WriteLine("Syötit: " + number);
                Console.WriteLine($"Vastaus: {f}");
            }
            else
            {
                Console.WriteLine("Määrittelemätön");
            }
            Console.WriteLine("Kiitos!");
            Console.ReadKey();

        }
    }
}
