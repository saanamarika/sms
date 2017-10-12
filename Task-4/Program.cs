using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma antaa negatiivisten lukujen summan. Parillinen ja Pariton. Syötä luku: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);


        }
    }
}
