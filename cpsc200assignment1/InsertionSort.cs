using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace cpsc200assignment1
{
    class InsertionSort : Sort
    {
        public InsertionSort()
        {
            
        }

        public void sort(ExperimentParams e)
        {
            Stopwatch sW = Stopwatch.StartNew();
            int listSize = e.list.Length;
            for(int i = 1; i < listSize; i++)
            {
                int val = e.list[i];
                int j = i;
                while (j > 0 && e.list[j - 1] > val)
                {
                    e.list[j] = e.list[j - 1];
                    j--;
                }
                e.list[j] = val;
            }
            sW.Stop();
            e.runTime = sW.ElapsedMilliseconds;
            sW.Reset();
            //printList(e.list);
        }

        public void printList(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
