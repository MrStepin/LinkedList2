using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    public class LinkedList<T>
    {
        private Element<T> _firstElement;
        private Element<T> _lastElement;


        public void Add(T data)
        {
            Element<T> element = new Element<T>(data);

            if (_firstElement == null)
            {
                _firstElement = element;
            }
            else
            {
                _lastElement.Next = element;
            }
            _lastElement = element;
        }

        public void ClearListBySelectedNumber(T number)
        {
            Element<T> currentElement = _firstElement;
            Element<T> previousElement = null;
            if (_firstElement == null)
            {
                return;
            }
            while (currentElement != null)
            {
                if (currentElement.Data.Equals(number))
                {
                    if (currentElement.Next == null)
                    {
                        _lastElement = previousElement;
                    }
                    if (previousElement != null)
                    {
                        previousElement.Next = currentElement.Next;
                        currentElement = currentElement.Next;
                    }
                    if (previousElement == null)
                    {
                        _firstElement = currentElement.Next;
                        currentElement = currentElement.Next;
                    }
                }
                else
                {
                    previousElement = currentElement;
                    currentElement = currentElement.Next;
                }
            }
        }
        public void Print()
        {
            Element<T> current = _firstElement;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
            Console.ReadKey();
        }
    }
}
