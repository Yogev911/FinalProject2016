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