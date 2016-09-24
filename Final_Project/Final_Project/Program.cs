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
            while (true)
            {
                Console.WriteLine("Please enter the city");
                Location city = new Location(Console.ReadLine());


            }    

      
                
                
                //string temp = Console.ReadLine();

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
