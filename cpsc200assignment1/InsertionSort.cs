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
            e.runTime = sW.ElapsedMilliseconds;
            //Console.WriteLine(e.runTime);
            sW.Reset();
            sortCheck(list, e);
            Console.WriteLine(e.arrayCheck);
        }

        private void sortReverse(ExperimentParams e)
        {
            list = e.list;
            sW = Stopwatch.StartNew();
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
            e.runTime = sW.ElapsedMilliseconds;
            //Console.WriteLine(e.runTime);
            sW.Reset();
            sortCheck(list, e);
            Console.WriteLine(e.arrayCheck);
        }
        private void sortCheck(int[] list, ExperimentParams e)
        {
            switch (e.sortDirection)
            {
                case SortDirection.normal:
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
                case SortDirection.reverse:
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
