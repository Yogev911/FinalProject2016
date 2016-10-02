using Microsoft.VisualStudio.TestTools.UnitTesting;
using Weather_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Library.Tests
{
    [TestClass()]
    public class OpenWeatherMapTests
    {
        OpenWeatherMap WDMTest = OpenWeatherMap.Instance;

        [TestMethod()]
        public void GetWDTest()
        {
            WDMTest.GetWeatherData(new Location("Paris"));
            Assert.IsNotNull(WDMTest.GetWD());
        }

        [TestMethod()]
        public void ClearWeatherDataTest()
        {
            WDMTest.GetWeatherData(new Location("Paris"));
            Assert.IsNotNull(WDMTest.GetWD());
            WDMTest.ClearWeatherData();
            Assert.IsNull(WDMTest.GetWD());
        }

        [TestMethod()]
        public void GetWeatherDataTest()
        {
            WDMTest.GetWeatherData(new Location("Paris"));
            Assert.AreEqual<string>(WDMTest.GetWD().cityName, "Paris");
            Assert.AreEqual<string>(WDMTest.GetWD().coordLon, "2.35");
            Assert.AreEqual<string>(WDMTest.GetWD().coordLat, "48.85");
            Assert.AreEqual<string>(WDMTest.GetWD().country, "FR");
            Assert.AreEqual<string>(WDMTest.GetWD().lastupdate, "2016-10-02T07:22:08");
            Assert.AreEqual<string>(WDMTest.GetWD().sunRise, "2016-10-02T05:52:29");
            Assert.AreEqual<string>(WDMTest.GetWD().sunSet, "2016-10-02T17:26:05");
            Assert.AreEqual<string>(WDMTest.GetWD().tempatureMin, "8.89");
            Assert.AreEqual<string>(WDMTest.GetWD().tempatureMax, "11.11");
            Assert.AreEqual<string>(WDMTest.GetWD().tempature, "9.81");
            Assert.AreEqual<string>(WDMTest.GetWD().humidity, "92");
            Assert.AreEqual<string>(WDMTest.GetWD().pressure, "1013");
            Assert.AreEqual<string>(WDMTest.GetWD().windSpeed, "4.91");
            Assert.AreEqual<string>(WDMTest.GetWD().clouds, "few clouds");
            Assert.AreEqual<string>(WDMTest.GetWD().weather, "few clouds");
        }
    }
}