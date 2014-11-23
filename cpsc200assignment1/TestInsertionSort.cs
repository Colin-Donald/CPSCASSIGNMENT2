using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    public class TestInsertionSort : TestSort
    {
        private int[] list;
        public TestInsertionSort()
        {
            
        }

        public void sort(TestExperimentParams e)
        {
            list = e.list;
            int listSize = list.Length;
            for (int i = 1; i < listSize; i++)
            {
                int val = list[i];
                int j = i;
                switch (e.tsp.sortDirection)
                {
                    case SortDirection.ascending:
                        {
                            while (j > 0 && list[j - 1] > val)
                            {
                                list[j] = list[j - 1];
                                j--;
                            }
                            break;
                        }
                    case SortDirection.descending:
                        {
                            while (j > 0 && list[j - 1] < val)
                            {
                                list[j] = list[j - 1];
                                j--;
                            }
                            break;
                        }
                }



                list[j] = val;
            }
            sortCheck(list, e);
        }
         private void sortCheck(int[] list, TestExperimentParams e)
        {
            switch (e.tsp.sortDirection)
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
