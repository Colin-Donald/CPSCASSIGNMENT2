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
            Console.WriteLine(e.runTime);
            sW.Reset();
        }

        private void sortReverse(ExperimentParams e)
        {
            Stopwatch sW = Stopwatch.StartNew();
            int listSize = e.list.Length;
            for (int i = 1; i < listSize; i++)
            {
                int val = e.list[i];
                int j = i;
                while (j > 0 && e.list[j - 1] < val)
                {
                    e.list[j] = e.list[j - 1];
                    j--;
                }
                e.list[j] = val;
            }
            sW.Stop();
            e.runTime = sW.ElapsedMilliseconds;
            Console.WriteLine(e.runTime);
            sW.Reset();
        }
    }
}
