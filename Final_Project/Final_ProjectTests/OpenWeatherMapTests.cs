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
            if (WDMTest.GetWD() == null)
                Assert.Fail();
        }

        [TestMethod()]
        public void ClearWeatherDataTest()
        {
            WDMTest.GetWeatherData(new Location("London"));
            if(WDMTest.GetWD() != null)
                WDMTest.ClearWeatherData();
            if (WDMTest.GetWD() != null)
                 Assert.Fail();
        }

        [TestMethod()]
        public void GetWeatherDataTest()
        {
            WDMTest.GetWeatherData(new Location("London"));
            if (WDMTest.GetWD() == null)
                Assert.Fail();
        }
    }
}