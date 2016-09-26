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
        [TestMethod()]
        public void GetWDTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ClearWeatherDataTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetWeatherDataTest(Location loc)
        {
            loc = new Location("paris");
            
            Assert.Fail();
        }
    }
}