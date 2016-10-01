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
    public class LocationTests
    {

        [TestMethod()]
        public void LocationTest()
        {
            Location LocationTest = new Location("London");
            Assert.AreEqual<string>(LocationTest.LocName, "London");
        }
    }
}