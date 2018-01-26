
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericSmallStack<T>
    {
        class SmallStack
        {
            private T[] pole = new T[10];
            private int index = 0; //index ktory ukazuje na vrchol zasobniku
            public void Push(T obj)
            {  // index uz je na konci pole a proto nesmim pridat. vyhdzuji vyjimku
                if (index == pole.Length - 1)
                {
                    throw new OutOfMemoryException();
                }
                else
                {
                    pole[index] = obj;
                    index++;
                }



            }
            public T Pop()
            {
                if (index - 1 < 0)
                {
                    throw new OutOfMemoryException();
                }

                return pole[index--];   // znizi index

            }


        }
    }
}
