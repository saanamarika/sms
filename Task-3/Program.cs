using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ohjelma antaa parittomien ja parillisten yhteissumman, syötä luku: ");
            String userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            int x = 0;
            int y = 0;
            int i = 0;
            while (number >= i)
            {
                if (i % 2 == 0)
                {
                   x += i;
                }
                else
                {
                   y += i;
                }
                   i++;
                }
            Console.WriteLine("Syötit: " + number);
            Console.WriteLine($"Vastaus: Parilliset={x} Parittomat={y}");
            Console.WriteLine("Kiitos!");
            Console.ReadKey();
        }


    }
}
