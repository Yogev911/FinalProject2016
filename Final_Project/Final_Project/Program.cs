using Final_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData d = new WeatherData();
            d.printXML();

            for (;;)
            {
                Console.WriteLine("Please enter your name");
                string temp = Console.ReadLine();
                Console.WriteLine("Hi, " + temp);
                if (temp.Equals("testing1"))
                {
                    Console.WriteLine("Bye World");
                    break;
                }
                else
                {
                    Console.WriteLine("You are not the king so... try again");
                }
            }
            Console.WriteLine("Bye Bye");
        }
    }
}
