﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
/*
    the object from this class "WeatherData" will have parameters and 
    data on specifyt location.
    this class not doing anything except "holding" the data 
*/
namespace Final_Project
{
    public class WeatherData { 
        public string city { get; set; }
        public string tempature { get; set; }
        public string wind { get; set; }
        public string country { get; set; }
    }
}
