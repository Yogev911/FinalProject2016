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
                Console.WriteLine("Or to be more specific it's in coord {0} , {0} ", service.GetWD().coordLat, service.GetWD().coordLon);
                Console.WriteLine("The last update I have is from {0}", service.GetWD().lastupdate);
                Console.WriteLine("the weather looks {0} ", service.GetWD().weather);
                Console.WriteLine("The sun will rise in {0} and set at {1}", service.GetWD().sunRise, service.GetWD().sunSet);
                Console.WriteLine("the tempature now is {0} and it should be between {1} - {2}", service.GetWD().tempature, service.GetWD().tempatureMin, service.GetWD().tempatureMax);
                Console.WriteLine("the wind speed is {0} MPH", service.GetWD().windSpeed);
                Console.WriteLine("the pressure (hmm wtf is this..) is {0} phd?!", service.GetWD().pressure);
                Console.WriteLine("cloud status is {0} and that's great", service.GetWD().clouds);
                Console.WriteLine("the humidity is {0}% ", service.GetWD().humidity);
                service.ClearWeatherData();
                
            }
            Console.WriteLine("bye bye and thank you for using Nir and Yogev code");
        }
    }
}
