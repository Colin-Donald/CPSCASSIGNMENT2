using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class TestGenArray
    {
        private Random r;
        private ArrayType arrayType;
        public TestGenArray()
        {
             r = new Random();
        }

        public int[] genArray(int arraySize, int[] list)
        {
            switch (arrayType)
            {
                case ArrayType.normal:
                {
                    return genArrayNormal(arraySize,list);
                }
                case ArrayType.reverse:
                {

                    return genReverseArray(genArrayNormal(arraySize,list));
                }
                case ArrayType.distinct:
                {
                    return genDistinctArray(arraySize,list);
                }
            }
            return null;
        }

        private int[] genReverseArray(int[] list)
        {
            int listSize = list.Length;
            int nextPos = 0;
            while(nextPos < listSize)
            {
                int minElement = nextPos;
                for(int i = nextPos + 1; i < listSize; i++)
                {
                    if(list[i] <  list[minElement])
                    {
                        minElement = i;
                    }
                }
                int temp = list[minElement];
                list[minElement] = list[nextPos];
                list[nextPos] = temp;
                nextPos++;
            }
            return list;
        }

        public int[] genArray(ArrayType arrayType, int arraySize, int[] list)
        {
            this.arrayType = arrayType;
            switch (arrayType)
            {
                case ArrayType.normal:
                {
                    
                    return genArrayNormal(arraySize,list);
                }
                case ArrayType.distinct:
                {
                    return genDistinctArray(arraySize,list);
                }
            }
            return null;
        }

        private int[] genArrayNormal(int arraySize,int[] list)
        {
            for (int i = 0; i < arraySize; i++)
            {
                list[i] = r.Next();
            }
            return list;
        }

        private int[] genDistinctArray(int arraySize, int[] list)
        {
            for (int i = 0; i < arraySize; i++)
            {
                list[i] = r.Next(0,6);
            }
            return list;
        }
    }
}
