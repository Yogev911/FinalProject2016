using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
/*
    the object from this class "WeatherData" will have parameters and 
    data on specifyt location.
    this class not doing anything except "holding" the data 
*/
namespace Final_Project
{
    public class WeatherData { 
        public string cityName { get; set; }
        public string coordLon { get; set; }
        public string coordLat { get; set; }
        public string country { get; set; }
        public string sunRise { get; set; }
        public string sunSet { get; set; }
        public string tempatureMin { get; set; }
        public string tempatureMax { get; set; }
        public string tempature { get; set; }
        public string humidity { get; set; }
        public string pressure { get; set; }
        public string windSpeed { get; set; }
        public string clouds { get; set; }
        public string weather { get; set; }
        public string lastupdate { get; set; }

    }
}
