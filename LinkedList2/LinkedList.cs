using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    public class LinkedList<T>
    {
        private Element<T> firstElement;
        private Element<T> lastElement;


        public void Add(T data)
        {
            Element<T> element = new Element<T>(data);

            if (firstElement == null)
            {
                firstElement = element;
            }
            else
            {
                lastElement.Next = element;
            }
            lastElement = element;
        }

        public void ClearListBySelectedNumber(T number)
        {
            Element<T> currentElement = firstElement;
            Element<T> previousElement = null;
            if (firstElement == null)
            {
                return;
            }
            while (currentElement != null)
            {
                if (currentElement.Data.Equals(number) && (previousElement != null))
                {
                    if (currentElement.Next == null)
                    {
                        lastElement = previousElement;
                    }

                    //if (currentElement.Next != null && (currentElement.Data.Equals(number) == currentElement.Next.Data.Equals(number)))
                    //{

                    //}
                    previousElement.Next = currentElement.Next;
                    
                }
                previousElement = currentElement;
                currentElement = currentElement.Next;
            }
        }
        public void Print()
        {
            Element<T> current = firstElement;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
            Console.ReadKey();
        }
    }
}
