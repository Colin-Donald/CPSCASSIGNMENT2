using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    public class GenArray
    {
        private Random r;
        public GenArray()
        {
             r = new Random();
        }

        public int[] genArray(int arraySize)
        {
            int i = 0;
            int[] list = new int[arraySize];
            while(arraySize> i)
            {
                list[i] = r.Next();
            }
            return list;
        }
    }
}
