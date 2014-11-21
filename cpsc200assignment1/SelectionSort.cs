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
        private int mem;
        public SelectionSort()
        {
            
        }



        public void sort(ExperimentParams e)
        {
            list = e.list;
            sW = Stopwatch.StartNew();
            int listSize = list.Length;
            mem += 32;
            int nextPos = 0;
            mem += 32;
            while (nextPos < listSize)
            {
                int minElement = nextPos;
                mem += 32;
                switch (e.s.sortDirection)
                {
                    case SortDirection.ascending:
                        {
                            for (int i = nextPos + 1; i < listSize; i++)
                            {
                                if (list[i] < list[minElement])
                                {
                                    minElement = i;
                                    mem += 32;
                                    mem -= 32;
                                }
                            }
                            break;
                        }
                    case SortDirection.descending:
                        {
                            for (int i = nextPos + 1; i < listSize; i++)
                            {
                                if (list[i] > list[minElement])
                                {
                                    minElement = i;
                                    mem += 32;
                                }
                                mem -= 32;
                            }
                            break;
                        }
                }
                int temp = list[minElement];
                list[minElement] = list[nextPos];
                mem += 32;
                list[nextPos] = temp;
                mem += 32;
                nextPos++;
                mem -= 96;
            }
            mem -= 64;
            sW.Stop();
            e.runTime = sW.ElapsedMilliseconds;
            Console.WriteLine(e.runTime);
            sW.Reset();
            e.memory = mem;
            sortCheck(list, e);
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
