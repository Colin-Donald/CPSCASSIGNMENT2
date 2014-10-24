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
        private int mem;
        public InsertionSort()
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
            sW = Stopwatch.StartNew();
            int listSize = list.Length;
            mem += 32;
            for(int i = 1; i < listSize; i++)
            {
                int val = list[i];
                mem += 32;
                int j = i;
                mem += 32;
                while (j > 0 && list[j - 1] > val)
                {
                    list[j] = list[j - 1];
                    mem += 32;
                    j--;
                    mem -= 32;
                }
                
                list[j] = val;
                mem += 32;
                mem -= 96;
            }
            mem -= 32;
            sW.Stop();
            e.runTime = sW.ElapsedMilliseconds;
            Console.WriteLine(e.runTime);
            sW.Reset();
            e.memory = mem;
            sortCheck(list, e);
            //Console.WriteLine(e.arrayCheck);
        }

        private void sortReverse(ExperimentParams e)
        {
            list = e.list;
            sW = Stopwatch.StartNew();
            int listSize = list.Length;
            mem += 32;
            for (int i = 1; i < listSize; i++)
            {
                int val = list[i];
                mem += 32;
                int j = i;
                mem += 32;
                while (j > 0 && list[j - 1] < val)
                {
                    list[j] = list[j - 1];
                    mem += 32;
                    j--;
                }
                mem -= 32;
                list[j] = val;
                mem += 32;
            }
            mem -= 96;
            mem -= 32;
            sW.Stop();
            e.runTime = sW.ElapsedMilliseconds;
            Console.WriteLine(e.runTime);
            sW.Reset();
            e.memory = mem;
            sortCheck(list, e);
            //Console.WriteLine(e.arrayCheck);
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
