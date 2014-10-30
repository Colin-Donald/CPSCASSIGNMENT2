using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace cpsc200assignment1
{
    class QuickSort : Sort
    {
        private int[] list;
        private Stopwatch sW;
        private int mem;
        private int lhs;
        private int rhs;
        private QuickSort()
        {
        }

        public void sort(ExperimentParams e)
        {
            switch (e.sortDirection)
            {
                case SortDirection.ascending:
                {
                    sortAscending(e);
                    break;
                }
                case SortDirection.descending:
                {
                    break;
                }
            }
        }

        private void sortAscending(ExperimentParams e)
        {
            list = e.list;
            rhs = list.Length - 1;
            lhs = 0;
            quickSort(list, lhs, rhs);
        }

        private void quickSort(int[] list, int lhs, int rhs)
        {
            int pivotVal = choosePivotVal(list, lhs, rhs);
            int i = lhs;
            int j = rhs;
            while(i <= j)
            {
                while(list[i] < pivotVal)
                {
                    i++;
                }
                while(list[j] > pivotVal)
                {
                    j--;
                }
                if(i <= j)
                {
                    swap(list,i,j);
                    j--;
                    i++;
                }
            }
            if (lhs < j)
            {
                quickSort(list, lhs, j);
            }
            if (i< rhs)
            {
                quickSort(list, i, rhs);
            }
        }

        private void swap(int[] list, int i, int j)
        {
            throw new NotImplementedException();
        }

        private int choosePivotVal(int[] list, int lhs, int rhs)
        {
            throw new NotImplementedException();
        }
    }
}
