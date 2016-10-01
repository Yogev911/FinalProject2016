using Weather_Library;
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string CodeName;
            //IWeatherDataService service = WeatherDataServiceFactory.GetWeatherDataService(3);
            IWeatherDataService service = WeatherDataServiceFactory.GetWeatherDataService(WeatherDataServiceFactory.OPEN_WEATHER_MAP);

            while (true)
            {
                Console.WriteLine("Please enter the city or Exit to exit...");
                CodeName = Console.ReadLine();
                if (CodeName.Equals("Exit"))
                    break;
                //Location city = new Location(CodeName);
                /// Wd= OpenWeatherMapInstance.GetWeatherData(city);
                service.GetWeatherData(new Location(CodeName));
                if (service.GetWD() == null) continue;
                Console.WriteLine("Hey Sir, You requested to see the weather in {0} in country {1}", service.GetWD().cityName, service.GetWD().country);
                Console.WriteLine("the last update i have is from {0} \nthe weather looks {1} ", service.GetWD().lastupdate, service.GetWD().weather);
                Console.WriteLine("cloud status is {0} \nthe wind speed is {1} \nthe pressure (hmm wtf is this..) is {2}", service.GetWD().clouds, service.GetWD().windSpeed, service.GetWD().pressure);
                Console.WriteLine("the humidity is {0}% \n\n", service.GetWD().humidity);
                service.ClearWeatherData();
            
            }
            Console.WriteLine("bye bye and thank you for using Nir and Yogev code");
        }
    }
}
