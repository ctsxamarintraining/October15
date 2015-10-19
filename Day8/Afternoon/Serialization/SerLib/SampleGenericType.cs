using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerLib
{
    public class SampleGenericType<T> where T: class
    {
        public T MyType { get; set; }
    }
}
