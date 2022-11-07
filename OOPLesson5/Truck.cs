using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson5
{
    internal class Truck : Car
    {
        public int MaxLoad { get; set; }

        public Truck(int maxLoad , string manufacturer, string color)
            :base(manufacturer, color)
        {
            MaxLoad = maxLoad;
        }


        public new string Get()
        {
            return base.Get() + " " + MaxLoad;
        }

    }
}
