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
        public ShellSort()
        {

        }

        public void sort(ExperimentParams e)
        {
            switch (e.sortDirection)
            {
                case SortDirection.ascending:
                    {
                        sortNormal(e);
                        break;
                    }
                case SortDirection.descending:
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
                for (int i = gap; i < listSize; i++)
                {
                    int val = list[i];
                    int j = i - gap;
                    while (j >= 0 && list[j] > val)
                    {
                        list[j + gap] = list[j];
                        j -= gap;
                    }
                    list[j + gap] = val;
                }
            }
            sW.Stop();
            e.runTime = sW.ElapsedMilliseconds;
            sW.Reset();
            sortCheck(list, e);
            Console.WriteLine(e.arrayCheck);
        }

        private void sortReverse(ExperimentParams e)
        {
            list = e.list;
            gapSequence = e.gapSequence;
            sW = Stopwatch.StartNew();
            int listSize = list.Length;
            foreach (int gap in gapSequence)
            {
                for (int i = gap; i < listSize; i++)
                {
                    int val = list[i];
                    int j = i - gap;
                    while (j >= 0 && list[j] < val)
                    {
                        list[j + gap] = list[j];
                        j -= gap;
                    }
                    list[j + gap] = val;
                }
            }
            sW.Stop();
            e.runTime = sW.ElapsedMilliseconds;
            sW.Reset();
            sortCheck(list, e);
            Console.WriteLine(e.arrayCheck);
        }

        private void sortCheck(int[] list, ExperimentParams e)
        {
            switch (e.sortDirection)
            {
                case SortDirection.ascending:
                {
                    for (int i = 0; i < list.Length - 1; i++)
                    {
                        if (list[i] > list[i + 1])
                        {
                            e.arrayCheck = false;
                            break;
                        }
                    }
                    break;
                }
                case SortDirection.descending:
                {
                    for (int i = 0; i < list.Length - 1; i++)
                    {
                        if (list[i] < list[i + 1])
                        {
                            e.arrayCheck = false;
                            break;
                        }
                    }
                    break;
                }
            }
            
        }

    }
}
