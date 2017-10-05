using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_2_visual_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Maatalousnäyttelyn lipunhinta");
            Console.Write("Nimi: ");
            Console.ReadLine();

            int price = 20;
            int discount = 0;
            bool discounted = false;

            Console.Write("Ikä: ");
            int age = int.Parse(Console.ReadLine());

            //ikäehdot

            if (age < 7)
            {
                discount = 100;
                discounted = true;
            }
            else if (age >= 7 && age <= 15 && discounted==false)
            {
                discount = 50;
                discounted = true;
            }
            else if (age >= 65 && discounted==false)
            {
                discount = 50;
                discounted = true;
            }
            //muut ehdot
            
            if (age >15 && age <65)
            {
                Console.WriteLine("Oletko varusmies? Y/N");
                string armyresponse = (Console.ReadLine());
                if (armyresponse == "Y" || armyresponse == "y" && discounted==false)
                {
                    discount = 50;
                    discounted = true;
                }
                else
                {
                    Console.WriteLine("Oletko Mtk:n jäsen? Y/N");
                    string mtkresponse = (Console.ReadLine());
                    if (mtkresponse == "Y" || mtkresponse == "y" && discounted==false)
                    {
                        discount= 15;
                        discounted = true;
                    }

                    Console.WriteLine("Oletko opiskelija? Y/N");
                    string studentresponse = (Console.ReadLine());
                    if (studentresponse == "Y" || studentresponse == "y" && discounted==false)
                    {
                        discount = 45;
                        discounted = true;
                    }

                    //erikoisehto
                    if (mtkresponse == "Y" || mtkresponse == "y")
                    {
                        if (studentresponse == "Y" || studentresponse == "y")
                        {
                            discount = 15 + 45;
                        }
                    }
                }
            }
            //lopullinen hinta
            decimal lopullinen = (price - (price * Convert.ToDecimal(discount / 100m)));
            Console.WriteLine("Lippusi hinta on: " +lopullinen);
            Console.WriteLine("Tervetuloa!");
            Console.ReadKey();
        }
    }
}
