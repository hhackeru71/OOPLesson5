using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson5
{
    internal class Vehicle
    {
        public string Color { get; set; }

        public Vehicle(string color)
        {
            Color = color;
        }

        public string Get()
        {
            return Color;
        }
    }
}
