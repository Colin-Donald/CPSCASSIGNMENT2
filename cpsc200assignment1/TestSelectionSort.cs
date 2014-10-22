using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace cpsc200assignment1
{
    class TestSelectionSort : TestSort
    {
         private int[] list;
         public TestSelectionSort()
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
            int listSize = list.Length;
            int nextPos = 0;
            while (nextPos < listSize)
            {
                int minElement = nextPos;
                for (int i = nextPos + 1; i < listSize; i++)
                {
                    if (list[i] < list[minElement])
                    {
                        minElement = i;
                    }
                }
                int temp = list[minElement];
                list[minElement] = list[nextPos];
                list[nextPos] = temp;
                nextPos++;
            }
            e.list = list;
            sortCheck(list, e);
        }

        private void sortReverse(TestExperimentParams e)
        {
            list = e.list;
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
            e.list = list;
            sortCheck(list, e);
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
