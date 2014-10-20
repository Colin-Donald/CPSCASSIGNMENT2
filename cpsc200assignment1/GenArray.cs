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
        public GenArray()
        {
             r = new Random();
        }

        public int[] genArray(int arraySize)
        {
            this.arraySize = arraySize;
            switch (arrayType)
            {
                case ArrayType.normal:
                {
                    return genArray();
                }
                case ArrayType.distinct:
                {
                    return genDistinctArray();
                }
            }
            return null;
        }

        public int[] genArray(ArrayType arrayType, int arraySize)
        {
            this.arraySize = arraySize;
            this.arrayType = arrayType;
            switch (arrayType)
            {
                case ArrayType.normal:
                {
                    
                    return genArray();
                }
                case ArrayType.distinct:
                {
                    return genDistinctArray();
                }
            }
            return null;
        }

        private int[] genArray()
        {
            int[] list = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                list[i] = r.Next();
            }
            return list;
        }

        private int[] genDistinctArray()
        {
            int[] list = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                list[i] = r.Next(0,6);
            }
            return list;
        }
    }
}
