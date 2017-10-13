using System;

namespace Task_4._0
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
            int k = 1;
            if (number < 0)
            {
                k = -1;
            }
            do
            {
                x++;
                y += x;
            } while (x < number*k);

            Console.WriteLine("Syötit: " + number);
            Console.WriteLine($"Vastaus: {y*k}");

            Console.WriteLine("Kiitos!");
            Console.ReadKey();
        }
    }
}
