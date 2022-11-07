using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson5
{
    internal class Ship : Vehicle
    {
        public int Length { get; set; }

        public Ship(int length, string color)
         :base(color)
        {
            Length = length;
        }

        public new  string Get()
        {
            return base.Get() + " " + Length;
        }
    }
}
