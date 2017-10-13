using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Ohjelma antaa negatiivisten lukujen summan. Parillinen ja Pariton. Syötä luku: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            int x = 0, y = 0, i = 0, k=1;
            if (number < 0)
                k = -1;
            while (number * k >= i)
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
            Console.WriteLine($"Vastaus: Parilliset={x*k} Parittomat={y*k}");
            Console.WriteLine("Kiitos!");
            Console.ReadKey();

        }
    }
}
