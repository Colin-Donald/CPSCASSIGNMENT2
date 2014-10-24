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
        private int mem;
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
            mem += 32;
            foreach(int gap in gapSequence)
            {
                for (int i = gap; i < listSize; i++)
                {
                    int val = list[i];
                    mem += 32;
                    int j = i - gap;
                    mem += 32;
                    while (j >= 0 && list[j] > val)
                    {
                        list[j + gap] = list[j];
                        mem += 32;
                        j -= gap;
                        mem += 32;
                        mem -= 64;
                    }
                    list[j + gap] = val;
                    mem += 32;
                    mem -= 96;
                }
            }
            mem -= 32;
            sW.Stop();
            e.runTime = sW.ElapsedMilliseconds;
            sW.Reset();
            sortCheck(list, e);
            e.memory = mem;
            Console.WriteLine(e.runTime);
            Console.WriteLine(e.arrayCheck);
        }

        private void sortReverse(ExperimentParams e)
        {
            list = e.list;
            gapSequence = e.gapSequence;
            sW = Stopwatch.StartNew();
            int listSize = list.Length;
            mem += 32;
            foreach (int gap in gapSequence)
            {
                for (int i = gap; i < listSize; i++)
                {
                    int val = list[i];
                    mem += 32;
                    int j = i - gap;
                    mem += 32;
                    while (j >= 0 && list[j] < val)
                    {
                        list[j + gap] = list[j];
                        mem += 32;
                        j -= gap;
                        mem += 32;
                        mem -= 64;
                    }
                    list[j + gap] = val;
                    mem += 32;
                    mem -= 96;
                }

            }
            mem -= 32;
            sW.Stop();
            e.runTime = sW.ElapsedMilliseconds;
            sW.Reset();
            e.memory = mem;
            sortCheck(list, e);
            Console.WriteLine(e.runTime);
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
