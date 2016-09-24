using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class WeatherDataServiceFactory
    {
        public static IWeatherDataService OPEN_WETHER_MAP()
        {
            Console.WriteLine("OPEN_WEATHER_MAP");
            return OpenWeatherMap.Instance;
        }


    }
    
}
