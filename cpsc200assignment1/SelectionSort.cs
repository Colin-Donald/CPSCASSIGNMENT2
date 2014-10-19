using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace cpsc200assignment1
{
    class SelectionSort : Sort
    {
        public SelectionSort()
        {
            
        }

        public void sort(ExperimentParams e)
        {
            Stopwatch sW = Stopwatch.StartNew();
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
                int temp = e.list[minElement];
                e.list[minElement] = e.list[nextPos];
                e.list[nextPos] = temp;
                nextPos++;
            }
            sW.Stop();
            e.runTime = sW.ElapsedMilliseconds;
            sW.Reset();
            printList(e.list);
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
