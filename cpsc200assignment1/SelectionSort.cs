using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace cpsc200assignment1
{
    class SelectionSort : Sort
    {
        private Stopwatch sW;
        private int[] list;
        public SelectionSort()
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
            int nextPos = 0;
            while(nextPos < listSize)
            {
                int minElement = nextPos;
                for(int i = nextPos + 1; i < listSize; i++)
                {
                    if(list[i] <  list[minElement])
                    {
                        minElement = i;
                    }
                }
                int temp = list[minElement];
                list[minElement] = list[nextPos];
                list[nextPos] = temp;
                nextPos++;
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
            int nextPos = 0;
            while (nextPos < listSize)
            {
                int minElement = nextPos;
                for (int i = nextPos + 1; i < listSize; i++)
                {
                    if (list[i] > list[minElement])
                    {
                        minElement = i;
                    }
                }
                int temp = list[minElement];
                list[minElement] = list[nextPos];
                list[nextPos] = temp;
                nextPos++;
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
