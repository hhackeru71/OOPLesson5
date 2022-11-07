using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson5
{
    internal class Students : Person
    {
        public int Age { get; set; }
        public new  string GetName()
        {
            return base.GetName() + Age;
        }


    }
}
