using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return Console.ReadLine();
        }
    }


}
