using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * initialize data source
 * for now can use only openweathermap.com
 * in the future can add more source
 */
namespace Final_Project
{
    public class WeatherDataServiceFactory
    {
        public static int OPEN_WEATHER_MAP = 1;
        public static IWeatherDataService openWeatherMap()
        {
            Console.WriteLine("OPEN_WEATHER_MAP");
            return OpenWeatherMap.Instance;
        }
        public  static IWeatherDataService GetWeatherDataService(int temp)
        {
            if (temp == 1)
            {
                return openWeatherMap();
            }
            throw (new WeatherDataServiceException("Error no IWeatherDataService to return"));
        }

        

    }
    
}
