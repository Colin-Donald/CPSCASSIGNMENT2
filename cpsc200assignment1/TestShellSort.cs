using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class TestShellSort : TestSort
    {
        private int[] list;
        private int[] gapSequence;
        public TestShellSort()
        {

        }

        public void sort(TestExperimentParams e)
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

        private void sortNormal(TestExperimentParams e)
        {
            list = e.list;
            gapSequence = e.gapSequence;
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
            sortCheck(list, e);
            e.list = list;
            //Console.WriteLine(e.arrayCheck);
        }

        private void sortReverse(TestExperimentParams e)
        {
            list = e.list;
            gapSequence = e.gapSequence;
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
            sortCheck(list, e);
            e.list = list;
            //Console.WriteLine(e.arrayCheck);
        }

        private void sortCheck(int[] list, TestExperimentParams e)
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
