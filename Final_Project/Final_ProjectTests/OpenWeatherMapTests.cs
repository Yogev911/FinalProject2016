using Microsoft.VisualStudio.TestTools.UnitTesting;
using Final_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Tests
{
    
    [TestClass()]
    public class OpenWeatherMapTests
    {
        OpenWeatherMap WDMTest = OpenWeatherMap.Instance;

        [TestMethod()]
        public void GetWDTest()
        {
            WDMTest.GetWeatherData(new Location("London"));
            Assert.IsNotNull(WDMTest.GetWD());
        }

        [TestMethod()]
        public void ClearWeatherDataTest()
        {
            WDMTest.GetWeatherData(new Location("London"));
            Assert.IsNotNull(WDMTest.GetWD());
            WDMTest.ClearWeatherData();
            Assert.IsNull(WDMTest.GetWD());
        }

        [TestMethod()]
        public void GetWeatherDataTest()
        {

            WDMTest.GetWeatherData(new Location("London"));
            Assert.AreEqual<string>(WDMTest.GetWD().cityName, "London");
            Assert.AreEqual<string>(WDMTest.GetWD().coordLon, "-0.13");
            Assert.AreEqual<string>(WDMTest.GetWD().coordLat, "51.51");
            Assert.AreEqual<string>(WDMTest.GetWD().country, "GB");
            Assert.AreEqual<string>(WDMTest.GetWD().lastupdate, "2016-09-28T10:18:48");
            Assert.AreEqual<string>(WDMTest.GetWD().sunRise, "");
            Assert.AreEqual<string>(WDMTest.GetWD().sunSet, "");
            Assert.AreEqual<string>(WDMTest.GetWD().tempatureMin, "");
            Assert.AreEqual<string>(WDMTest.GetWD().tempatureMax, "");
            Assert.AreEqual<string>(WDMTest.GetWD().tempature, "");
            Assert.AreEqual<string>(WDMTest.GetWD().humidity, "");
            Assert.AreEqual<string>(WDMTest.GetWD().pressure, "");
            Assert.AreEqual<string>(WDMTest.GetWD().windSpeed, "");
            Assert.AreEqual<string>(WDMTest.GetWD().clouds, "");
            Assert.AreEqual<string>(WDMTest.GetWD().weather, "");


        }

    }
}