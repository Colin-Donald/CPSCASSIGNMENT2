using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class SelectionSort : Sort
    {
        public SelectionSort()
        {
            
        }

        public void sort(ExperimentParams e)
        {
            int listSize = e.list.Length;
            int nextPos = 0;
            while(nextPos < listSize)
            {
                int minElement = nextPos;
                for(int i = nextPos + 1; i < listSize; i++)
                {
                    if(e.list[i] < e.list[minElement])
                    {
                        minElement = i;
                    }
                }
                swap(e.list , minElement , nextPos);
                nextPos++;
            }

        }


        public void swap(int[] list , int minElement, int nexPos)
        {
            int temp = list[minElement];
            list[minElement] = list[nexPos];
            list[nexPos] = temp;
        }


        public void setArray()
        {

        }

        public void printList(int[] list)
        {
            for(int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
