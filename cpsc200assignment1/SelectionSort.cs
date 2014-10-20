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
        private Stopwatch sW;
        private int[] list;
        public SelectionSort()
        {
            
        }

        public void sort(ExperimentParams e)
        {
            list = e.list;
            sW = Stopwatch.StartNew();
     
            int listSize = list.Length;
            int nextPos = 0;
            while(nextPos < listSize)
            {
                int minElement = nextPos;
                for(int i = nextPos + 1; i < listSize; i++)
                {
                    if(list[i] < list[minElement])
                    {
                        minElement = i;
                    }
                }
                int temp = list[minElement];
                list[minElement] = list[nextPos];
                list[nextPos] = temp;
                nextPos++;
            }
            sW.Stop();
            e.runTime = sW.ElapsedMilliseconds;
            Console.WriteLine(e.runTime);
            sW.Reset();
        } 
    }
}
