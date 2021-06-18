using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    class Element<T>
    {
        public Element(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Element<T> Next { get; set; }
    }
}
