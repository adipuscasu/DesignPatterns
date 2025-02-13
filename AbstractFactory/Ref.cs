using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Ref<T> where T: class
    {
        public T Value { get; set; }
        public Ref(T value)
        {
            Value = value;
        }
    }
}
