using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class SmallStack
    {
        private int[] pole = new int[10];
        private int index = 0; //index ktory ukazuje na vrchol zasobniku
        public void Push(int cislo)
        {  // index uz je na konci pole a proto nesmim pridat. vyhdzuji vyjimku
            if (index == pole.Length - 1)
            {
                throw new OutOfMemoryException();
            }
            else
            {
                pole[index] = cislo;
                index++;
            }
                
            

        }
        public int Pop()
        {
            if (index -1 < 0)
            {
                throw new OutOfMemoryException();
            }

            return pole[index--];   // znizi index

        }


    }
}
