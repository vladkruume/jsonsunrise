using System;
using System.Collections.Generic;
using System.Text;

namespace SunriseSunsetAPI
{
    public class SunMode
    {
        public Results Results { get; set;}
        public string status { get; set;}
    }
    public class Results
    {
        public string sunrise { get; set;}
        public string sunset { get; set;}
    }
}
