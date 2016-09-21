using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Final_Project
{
    class WeatherData { 
    

        public void printXML()
        {
            Location loc = new Location();  
            var api = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&mode=xml&appid=2fccd10128467348a961d23fc6dc1f59&units=metric", loc.getLocation());
            try {

                XDocument xdoc =  XDocument.Load(api);
                Console.WriteLine(xdoc.ToString());
                Console.WriteLine(xdoc.Element("current").Element("city").Attribute("name").Value);


            }
            catch(Exception temp) {
                Console.WriteLine(temp);
            };

        }
    }
}
