using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    private class TestInsertionSort : TestSort
    {
         private int[] list;
        public TestInsertionSort()
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
            sortCheck(list, e);
            e.list = list;
        }

        private void sortReverse(TestExperimentParams e)
        {
            list = e.list;
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
            sortCheck(list, e);
            e.list = list;
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
