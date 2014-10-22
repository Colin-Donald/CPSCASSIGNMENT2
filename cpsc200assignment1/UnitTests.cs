using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class UnitTests
    {
        private bool functions;
        private TestExperimentParams eShell;
        private TestExperimentParams eSelection;
        private TestExperimentParams eInserstion;
        private TestSortFacade tsf;
        private TestInsertionSort IS;
        private TestSelectionSort SS;
        private TestShellSort SHS;
        private int[] list = new int[10] {10,5,3,6,7,2,4,8,1,9};
        public UnitTests()
        {
            eShell = new TestExperimentParams();
            eSelection = new TestExperimentParams();
            eInserstion = new TestExperimentParams();
            tsf = new TestSortFacade();
            IS = new TestInsertionSort();
            SS = new TestSelectionSort();
            SHS = new TestShellSort();
        }

        public bool selectionTest()
        {
            bool a, b, c;
            a = normalSelectionSort();
            b = reverseSelectionSort();
            c = distinctSelectionSort();
            if (a == true && b == true && c == true)
            {
                functions = true;
                return functions;
            }
            else
            {
                functions = false;
                return functions;
            }
        }

        public bool insertionTest()
        {
            bool a, b, c;
            a = normalInsertionSort();
            b = reverseInsertionSort();
            c = distinctInsertionSort();
            if (a == true && b == true && c == true)
            {
                functions = true;
                return functions;
            }
            else
            {
                functions = false;
                return functions;
            }
        }

        public bool shellTest()
        {
            bool a, b, c;
            a = normalShellSort();
            b = reverseShellSort();
            c = distinctShellSort();
            if (a == true && b == true && c == true)
            {
                functions = true;
                return functions;
            }
            else
            {
                functions = false;
                return functions;
            }
        }

        public bool normalSelectionSort()
        {
            bool a, b, c, d;
            a = normalSelectionSortAscending();
            b = normalSelectionSortAscendingSortFacade();
            c = normalSelectionSortDescending();
            d = normalSelectionSortDecendingSortFacade();
            if(a == true && b == true && c == true && d == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool normalSelectionSortAscending()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.normal,list);
            SS.sort(eSelection);
            return eShell.list == list;
        }

        public bool normalSelectionSortAscendingSortFacade()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.normal,list);
            tsf.sort(eSelection);
            return eShell.list == list;
        }
        
        public bool normalSelectionSortDescending()
        {
            eSelection.setParams(SortDirection.descending,Sorts.selectionSort,ArrayType.normal,list);
            SS.sort(eSelection);
            return eShell.list == list;
        }

        public bool normalSelectionSortDecendingSortFacade()
        {
            eSelection.setParams(SortDirection.descending,Sorts.selectionSort,ArrayType.normal,list);
            tsf.sort(eSelection);
            return eShell.list == list;
        }

        public bool reverseSelectionSort()
        {
            bool a, b, c, d;
            a = reverseSelectionSortAscending();
            b = reverseSelectionSortAscendingSortFacade();
            c = reverseSelectionSortDescending();
            d = reverseSelectionSortDescendingSortFacade();
            if (a == true && b == true && c == true && d == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool reverseSelectionSortAscending()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.reverse,list);
            SS.sort(eSelection);
            return eShell.list == list;
        }

        public bool reverseSelectionSortAscendingSortFacade()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.reverse,list);
            tsf.sort(eSelection);
            return eShell.list == list;
        }

        public bool reverseSelectionSortDescending()
        {
            eSelection.setParams(SortDirection.descending,Sorts.selectionSort,ArrayType.reverse,list);
            SS.sort(eSelection);
            return eShell.list == list;
        }

        public bool reverseSelectionSortDescendingSortFacade()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.reverse,list);
            SS.sort(eSelection);
            return eShell.list == list;
        }
        
        public bool distinctSelectionSort()
        {
            bool a, b, c, d;
            a = distinctSelectionsortAscending();
            b = distinctSelectionsortAscendingSortFacade();
            c = distinctSelectionsortDescending();
            d = distinctSelectionsortDescendingSortFacade();
            if (a == true && b == true && c == true && d == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool distinctSelectionsortAscending()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.distinct,list);
            tsf.sort(eSelection);
            return eShell.list == list;
        }

        public bool distinctSelectionsortAscendingSortFacade()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.distinct,list);
            SS.sort(eSelection);
            return eShell.list == list;
        }

        public bool distinctSelectionsortDescending()
        {
            eSelection.setParams(SortDirection.descending,Sorts.selectionSort,ArrayType.distinct,list);
            SS.sort(eSelection);
            return eShell.list == list;
        }

        public bool distinctSelectionsortDescendingSortFacade()
        {
            eSelection.setParams(SortDirection.descending,Sorts.selectionSort,ArrayType.distinct,list);
            tsf.sort(eSelection);
            return eShell.list == list;
        }

        public bool normalInsertionSort()
        {
            bool a, b, c, d;
            a = normalInerstionSortAscending();
            b = normalInerstionSortAscendingSortfacade();
            c = normalInerstionSortDescending();
            d = normalInerstionSortDescendingSortfacade();
            if (a == true && b == true && c == true && d == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool normalInerstionSortAscending()
        {
            eInserstion.setParams(SortDirection.ascending,Sorts.insertionSort,ArrayType.normal,list);
            IS.sort(eInserstion);
            return eShell.list == list;
        }

        public bool normalInerstionSortAscendingSortfacade()
        {
            eInserstion.setParams(SortDirection.ascending,Sorts.insertionSort,ArrayType.normal,list);
            tsf.sort(eInserstion);
            return eShell.list == list;
        }

        public bool normalInerstionSortDescending()
        {
            eInserstion.setParams(SortDirection.descending,Sorts.insertionSort,ArrayType.normal,list);
            IS.sort(eInserstion);
            return eShell.list == list;
        }

        public bool normalInerstionSortDescendingSortfacade()
        {
            eInserstion.setParams(SortDirection.descending,Sorts.insertionSort,ArrayType.normal,list);
            tsf.sort(eInserstion);
            return eShell.list == list;
        }

        public bool reverseInsertionSort()
        {
            bool a, b, c, d;
            a = reverseInerstionSortAscending();
            b = reverseInerstionSortAscendingSortfacade();
            c = reverseInerstionSortDescending();
            d = reverseInerstionSortDescendingSortfacade();
            if (a == true && b == true && c == true && d == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool reverseInerstionSortAscending()
        {
            eInserstion.setParams(SortDirection.ascending,Sorts.insertionSort,ArrayType.reverse,list);
            IS.sort(eInserstion);
            return eInserstion.list == list;
        }

        public bool reverseInerstionSortAscendingSortfacade()
        {
            eInserstion.setParams(SortDirection.ascending,Sorts.insertionSort,ArrayType.reverse,list);
            tsf.sort(eInserstion);
            return eShell.list == list;
        }

        public bool reverseInerstionSortDescending()
        {
            eInserstion.setParams(SortDirection.descending,Sorts.insertionSort,ArrayType.reverse,list);
            IS.sort(eInserstion);
            return eShell.list == list;
        }

        public bool reverseInerstionSortDescendingSortfacade()
        {
            eInserstion.setParams(SortDirection.descending,Sorts.insertionSort,ArrayType.reverse,list);
            tsf.sort(eInserstion);
            return eShell.list == list;
        }

        public bool distinctInsertionSort()
        {
            bool a, b, c, d;
            a = distinctInerstionSortAscending();
            b = distinctInerstionSortAscendingSortfacade();
            c = distinctInerstionSortDescending();
            d = distinctInerstionSortDescendingSortfacade();
            if (a == true && b == true && c == true && d == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
       public bool distinctInerstionSortAscending()
        {
            eInserstion.setParams(SortDirection.ascending,Sorts.insertionSort,ArrayType.distinct,list);
            IS.sort(eInserstion);
            return eShell.list == list;
        }

        public bool distinctInerstionSortAscendingSortfacade()
        {
            eInserstion.setParams(SortDirection.ascending,Sorts.insertionSort,ArrayType.distinct,list);
            tsf.sort(eInserstion);
            return eShell.list == list;
        }

        public bool distinctInerstionSortDescending()
        {
            eInserstion.setParams(SortDirection.descending,Sorts.insertionSort,ArrayType.distinct,list);
            IS.sort(eInserstion);
            return eShell.list == list;
        }

        public bool distinctInerstionSortDescendingSortfacade()
        {
            eInserstion.setParams(SortDirection.descending,Sorts.insertionSort,ArrayType.distinct,list);
            tsf.sort(eInserstion);
            return eShell.list == list;
        }

        public bool normalShellSort()
        {
            bool a, b, c, d;
            a = normalShellsortAscending();
            b = normalShellsortAscendingSortFacade();
            c = normalShellsortDecending();
            d = normalShellsortDescendingSortFacade();
            if (a == true && b == true && c == true && d == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool normalShellsortAscending()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.normal,list);
            SHS.sort(eShell);
            return eShell.list == list;
        }

        public bool normalShellsortAscendingSortFacade()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.normal,list);
            tsf.sort(eShell);
            return eShell.list == list;
        }

        public bool normalShellsortDecending()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.normal,list);
            SHS.sort(eShell);
            return eShell.list == list;
        }

        public bool normalShellsortDescendingSortFacade()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.normal,list);
            tsf.sort(eShell);
            return eShell.list == list;
        }

        public bool reverseShellSort()
        {
            bool a, b, c, d;
            a = reverseShellsortAscending();
            b = reverseShellsortAscendingSortFacade();
            c = reverseShellsortDecending();
            d = reverseShellsortDescendingSortFacade();
            if (a == true && b == true && c == true && d == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool reverseShellsortAscending()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.reverse,list);
            SHS.sort(eShell);
            return eShell.list == list;
        }

        public bool reverseShellsortAscendingSortFacade()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.reverse,list);
            tsf.sort(eShell);
            return eShell.list == list;;
        }

        public bool reverseShellsortDecending()
        {
            eShell.setParams(SortDirection.descending,Sorts.shellSort,ArrayType.reverse,list);
            SHS.sort(eShell);
            return eShell.list == list;
        }

        public bool reverseShellsortDescendingSortFacade()
        {
            eShell.setParams(SortDirection.descending,Sorts.shellSort,ArrayType.reverse,list);
            tsf.sort(eShell);
            return eShell.list == list;
        }

        public bool distinctShellSort()
        {
            bool a, b, c, d;
            a = distinctShellsortAscending();
            b = distinctShellsortAscendingSortFacade();
            c = distinctShellsortDecending();
            d = distinctShellsortDescendingSortFacade();
            if (a == true && b == true && c == true && d == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool distinctShellsortAscending()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.distinct,list);
            SHS.sort(eShell);
            return eShell.list == list;
        }

        public bool distinctShellsortAscendingSortFacade()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.distinct,list);
            tsf.sort(eShell);
            return eShell.list == list;
        }

        public bool distinctShellsortDecending()
        {
            eShell.setParams(SortDirection.descending,Sorts.shellSort,ArrayType.distinct,list);
            SHS.sort(eShell);
            return eShell.list == list;
        }

        public bool distinctShellsortDescendingSortFacade()
        {
            eShell.setParams(SortDirection.descending,Sorts.shellSort,ArrayType.distinct,list);
            tsf.sort(eShell);
            return eShell.list == list;
        }
    }
}
