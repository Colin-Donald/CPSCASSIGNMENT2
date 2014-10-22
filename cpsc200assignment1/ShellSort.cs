using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace cpsc200assignment1
{
    class ShellSort : Sort
    {
        private int[] list;
        private int[] gapSequence;
        private Stopwatch sW;
        private long mem1;
        private long mem2;
        public ShellSort()
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
            gapSequence = e.gapSequence;
            sW = Stopwatch.StartNew();
            int listSize = list.Length;
            foreach(int gap in gapSequence)
            {
                for (int i = 1; i < listSize; i++)
                {
                    int val = list[i];
                    int j = i - gap;
                    while (j > 0 && list[j - 1] > val)
                    {
                        list[j] = list[j - 1];
                        j -= gap;
                    }
                    list[j + gap] = val;
                }
            }
            sW.Stop();
            e.runTime = sW.ElapsedMilliseconds;
            //Console.WriteLine(e.runTime);
            sW.Reset();
            //e.list = list;
        }

        private void sortReverse(ExperimentParams e)
        {
            list = e.list;
            gapSequence = e.gapSequence;
            sW = Stopwatch.StartNew();
            int listSize = list.Length;
            foreach (int gap in gapSequence)
            {
                for (int i = 1; i < listSize; i++)
                {
                    int val = list[i];
                    int j = i - gap;
                    while (j > 0 && list[j - 1] < val)
                    {
                        list[j] = list[j - 1];
                        j -= gap;
                    }
                    list[j + gap] = val;
                }
            }
            sW.Stop();
            e.runTime = sW.ElapsedMilliseconds;
            //Console.WriteLine(e.runTime);
            sW.Reset();
            //e.list = list;
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
