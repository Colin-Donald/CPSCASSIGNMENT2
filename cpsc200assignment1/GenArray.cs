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
        private int arraySize;
        private ArrayType arrayType;
        private int[] list;
        public GenArray()
        {
             r = new Random();
        }

        public int[] genArray( int arraySize)
        {
            switch (arrayType)
            {
                case ArrayType.normal:
                {
                    genArray();
                    return list;
                }
                case ArrayType.distinct:
                {
                    genDistinctArray();
                    return list;
                }
            }
            return null;
        }

        public int[] genArray(ArrayType arrayType, int arraySize)
        {
            this.arraySize = arraySize;
            switch (arrayType)
            {
                case ArrayType.normal:
                {
                    genArray();
                    return list;
                }
                case ArrayType.distinct:
                {
                    genDistinctArray();
                    return list;
                }
            }
            return null;
        }

        private void genArray()
        {
            int i = 0;
            int[] list = new int[arraySize];
            while(arraySize> i)
            {
                list[i] = r.Next();
            }
            this.list = list;
        }

        private void genDistinctArray()
        {
            int i = 0;
            int[] list = new int[arraySize];
            while (arraySize > i)
            {
                list[i] = r.Next(6);
            }
            this.list = list;
        }
    }
}
