using Weather_Library;
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string CodeName;
            IWeatherDataService service = WeatherDataServiceFactory.GetWeatherDataService(WeatherDataServiceFactory.OPEN_WEATHER_MAP);
            while (true)
            {
                
                Console.WriteLine("Please enter the city or Exit to exit...");
                CodeName = Console.ReadLine();
                if (CodeName.Equals("Exit"))
                    break;
                service.GetWeatherData(new Location(CodeName));
                if (service.GetWD() == null) continue;
                Console.Clear();
                Console.WriteLine("Hey Sir, You requested to see the weather in {0} in country {1}", service.GetWD().cityName, service.GetWD().country);
                Console.WriteLine("Or to be more specific it's in coord {0} , {1} ", service.GetWD().coordLat, service.GetWD().coordLon);
                Console.WriteLine("The last update I have is from {0}", service.GetWD().lastupdate);
                Console.WriteLine("It seems to be {0} today ", service.GetWD().weather);
                Console.WriteLine("The sun will rise at {0} and set at {1}", service.GetWD().sunRise, service.GetWD().sunSet);
                Console.WriteLine("the tempature now is {0} and it should be between {1} - {2}", service.GetWD().tempature, service.GetWD().tempatureMin, service.GetWD().tempatureMax);
                Console.WriteLine("the wind speed is {0} MPH", service.GetWD().windSpeed);
                Console.WriteLine("the pressure is {0} hPa", service.GetWD().pressure);
                Console.WriteLine("cloud status is {0} and that's great", service.GetWD().clouds);
                Console.WriteLine("the humidity is {0}% \n\n\n\n", service.GetWD().humidity);
                service.ClearWeatherData();
            }
            Console.WriteLine("Copyrights Shenkar - Software Engineering");
            Console.WriteLine("Course Programming Languages Oct 2016 - By Mr. Life Michael ");
            Console.WriteLine("Written by Yogev Heskia and Nir Mekin ");
        }
    }
}
