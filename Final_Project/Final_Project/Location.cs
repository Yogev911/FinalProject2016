using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * holding Locationk data
 */
namespace Final_Project
{
    public class Location
    {
        public string locName { get; set; }
        public Location(string loc)
        {
            locName = loc;
        }
        public string getLocation()
        {
            Console.WriteLine("hello nir");
            return Console.ReadLine();
        }
    }


}
