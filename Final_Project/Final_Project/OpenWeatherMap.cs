using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/*
    class OpenWeatherMap implements IWeatherDataService and parse the XML which
    can be find at  api.openweathermap.org/data/2.5/weather.
    after parse the xml it saves the data on object from WeatherData which it creates
    uses singleton
*/
namespace Final_Project
{
    public class OpenWeatherMap : IWeatherDataService
    {
        private WeatherData weatherData;

        private static OpenWeatherMap instance;

        private OpenWeatherMap() { 
        }

        public static OpenWeatherMap Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OpenWeatherMap();
                }
                return instance;
            }
        }

        public WeatherData GetWD()
        {
            return weatherData;
        }
        public void ClearWeatherData()
        {
            weatherData = null;
        }
        public WeatherData GetWeatherData(Location location)
        {
            Console.WriteLine("start format...");
            weatherData = new WeatherData();
            string tmpLoc;
            tmpLoc = location.LocName.ToUpper();
            var api = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&mode=xml&appid=2fccd10128467348a961d23fc6dc1f59&units=metric", tmpLoc);
            try
            { 
                XDocument xdoc = XDocument.Load(api);
                //Console.WriteLine(xdoc.ToString());
                //city elements
                weatherData.cityName = xdoc.Element("current").Element("city").Attribute("name").Value;
                if (!tmpLoc.Equals(weatherData.cityName.ToUpper()))
                {
                    ClearWeatherData();
                    throw (new System.Xml.XmlException("Error not valid city name"));
                }
                weatherData.coordLon = xdoc.Element("current").Element("city").Element("coord").Attribute("lon").Value;
                weatherData.coordLat = xdoc.Element("current").Element("city").Element("coord").Attribute("lat").Value;
                weatherData.country = xdoc.Element("current").Element("city").Element("country").Value;
                weatherData.sunRise = xdoc.Element("current").Element("city").Element("sun").Attribute("rise").Value;
                weatherData.sunSet = xdoc.Element("current").Element("city").Element("sun").Attribute("set").Value;
                //temperature elements
                weatherData.tempature = xdoc.Element("current").Element("temperature").Attribute("value").Value;
                weatherData.tempatureMin = xdoc.Element("current").Element("temperature").Attribute("min").Value;
                weatherData.tempatureMax = xdoc.Element("current").Element("temperature").Attribute("max").Value;
                //humidity
                weatherData.humidity = xdoc.Element("current").Element("humidity").Attribute("value").Value;
                //pressure
                weatherData.pressure = xdoc.Element("current").Element("pressure").Attribute("value").Value;
                //wind
                weatherData.windSpeed = xdoc.Element("current").Element("wind").Element("speed").Attribute("value").Value;
                //clouds
                weatherData.clouds = xdoc.Element("current").Element("clouds").Attribute("name").Value;
                //weather
                weatherData.weather = xdoc.Element("current").Element("weather").Attribute("value").Value;
                //lastupdate
                weatherData.lastupdate = xdoc.Element("current").Element("lastupdate").Attribute("value").Value;
                
                // if (!tmpLoc.Equals(weatherData.cityName))
                //throw ("the city you entered is no mached to the xml");

            }
            catch (System.Xml.XmlException ex)
            {
                new WeatherDataServiceException("bad operation",ex);
                // Console.WriteLine(Xe);
                ClearWeatherData();
                return null;
                
            };
            
            return weatherData;
        }
    }

}
