using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace cpsc200assignment1
{
    public class TestShellSort : TestSort
    {
        private int[] list;
        private int[] gapSequence;
        private int mem;
        private Stopwatch sW;
        public TestShellSort()
        {

        }

        public void sort(ExperimentParams e)
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
                    switch (e.s.sortDirection)
                    {
                        case SortDirection.ascending:
                            {

                                while (j >= 0 && list[j] > val)
                                {
                                    list[j + gap] = list[j];
                                    mem += 32;
                                    j -= gap;
                                    mem += 32;
                                    mem -= 64;
                                }
                                break;
                            }
                        case SortDirection.descending:
                            {
                                while (j >= 0 && list[j] < val)
                                {
                                    list[j + gap] = list[j];
                                    mem += 32;
                                    j -= gap;
                                    mem += 32;
                                    mem -= 64;
                                }
                                break;
                            }
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

        private void sortCheck(int[] list, ExperimentParams e)
        {
            switch (e.s.sortDirection)
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
