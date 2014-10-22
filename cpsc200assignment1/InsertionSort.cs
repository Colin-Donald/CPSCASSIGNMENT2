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
        private int[] list;
        private Stopwatch sW;
        private long mem1;
        private long mem2;
        public InsertionSort()
        {
            
        }

        public void sort(ExperimentParams e)
        {
            switch (e.sortDirection)
            {
                case SortDirection.normal:
                    {
                        sortNormal(e);
                        break;
                    }
                case SortDirection.reverse:
                    {
                        sortReverse(e);
                        break;
                    }
            }
        }

        private void sortNormal(ExperimentParams e)
        {
            list = e.list;
            sW = Stopwatch.StartNew();
            mem1 = GC.GetTotalMemory(false);
            int listSize = list.Length;
            for(int i = 1; i < listSize; i++)
            {
                int val = list[i];
                int j = i;
                while (j > 0 && list[j - 1] > val)
                {
                    list[j] = list[j - 1];
                    j--;
                }
                list[j] = val;
            }
            sW.Stop();
            mem2 = GC.GetTotalMemory(false);
            e.memory = (int)(mem2 - mem1);
            e.runTime = sW.ElapsedMilliseconds;
            Console.WriteLine(e.runTime);
            sW.Reset();
            //e.list = list;
        }

        private void sortReverse(ExperimentParams e)
        {
            list = e.list;
            sW = Stopwatch.StartNew();
            mem1 = GC.GetTotalMemory(false);
            int listSize = list.Length;
            for (int i = 1; i < listSize; i++)
            {
                int val = list[i];
                int j = i;
                while (j > 0 && list[j - 1] < val)
                {
                    list[j] = list[j - 1];
                    j--;
                }
                list[j] = val;
            }
            sW.Stop();
            mem2 = GC.GetTotalMemory(false);
            e.memory = (int)(mem2 - mem1);
            e.runTime = sW.ElapsedMilliseconds;
            Console.WriteLine(e.runTime);
            sW.Reset();
            //e.list = list;
        }
    }
}
