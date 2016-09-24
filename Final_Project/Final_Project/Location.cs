using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * holding Location data
 */
namespace Final_Project
{
    public class Location
    {
        public string LocName { get; set; }
        public Location(string loc)
        {
            LocName = loc;
        }
    }
}
