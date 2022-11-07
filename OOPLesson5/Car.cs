using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson5
{
    internal class Car : Vehicle
    {

        public string Manufacturer { get; set; }

        public Car(string manufacturer ,string color)
            :base(color)
        {
            Manufacturer = manufacturer;
        }

    

        public new string Get()
        {
            return base.Get() + " " + Manufacturer;
        }


    }
}
