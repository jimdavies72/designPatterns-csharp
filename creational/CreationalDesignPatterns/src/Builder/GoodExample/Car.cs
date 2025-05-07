using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreationalDesignPatterns.src.Builder.GoodExample.Components;

namespace CreationalDesignPatterns.src.Builder.GoodExample
{
    public class Car
    {
        public CarType Type { get; set; }
        public int Seats { get; set; }
        public bool isConvertible { get; set; }
        public Engine? Engine { get; set; }
        public Dashboard? Dashboard { get; set; }
        public Wheels? Wheels { get; set; }
        public GPSNavigator? GpsNavigator { get; set; }

        // Fields specific to this class:
        public double Fuel { get; set; }
    }
}