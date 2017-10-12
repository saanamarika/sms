using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Ohjelma laskee kertoman. Anna luku, jonka kertoma lasketaan: ");
            String userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            int x = 0;
            int y = 0;
            if (number > 0)
            {
                do
                {
                    x++;
                    y += x;
                } while (x < number);

                Console.WriteLine("Syötit: " + number);
                Console.WriteLine($"Vastaus: {y}");
            }
            else
            {
                Console.WriteLine("Maarittelematon");
            }

            Console.WriteLine("Kiitos!");
            Console.ReadKey();
        }
    }
}
