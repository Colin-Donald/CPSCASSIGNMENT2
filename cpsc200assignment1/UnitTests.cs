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
        private int[] list = new int[10] { 10, 5, 3, 6, 7, 2, 4, 8, 1, 9 };
        private int[] reverselist = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        private int[] distinctlist = new int[10] { 0, 4, 3, 2, 2, 1, 4, 5, 3, 2 };
        private int[] listAns = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private int[] distinctlistAns = new int[10] { 0, 1, 2, 2, 2, 3, 3, 4, 4, 5 };
        private int[] descendingDistinctlistAns = new int[10] { 5, 4, 4, 3, 3, 2, 2, 2, 1, 0 };
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

        public bool RunAllSortTests()
        {
            bool a,b,c;
            a = selectionTest();
            b = insertionTest();
            c = shellTest();
            if (a == true && b == true && c == true)
            {
                functions = true;
                Console.WriteLine("pass");
                return functions;
            }
            else
            {
                Console.WriteLine("fail");
                functions = false;
                return functions;
            }
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
                Console.WriteLine("selection sort passed!!!! ");
                return functions;
            }
            else
            {
                Console.WriteLine("selection Sort failed!!!!");
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
                Console.WriteLine("pass");
                return functions;
            }
            else
            {
                Console.WriteLine("fail");
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
                Console.WriteLine("pass");
                return functions;
            }
            else
            {
                Console.WriteLine("fail");
                functions = false;
                return functions;
            }
        }

        public bool normalSelectionSort()
        {
            Console.WriteLine("normal array selection sort");
            bool a, b, c, d;
            a = normalSelectionSortAscending();
            b = normalSelectionSortAscendingSortFacade();
            c = normalSelectionSortDescending();
            d = normalSelectionSortDecendingSortFacade();
            if(a == true && b == true && c == true && d == true)
            {
                Console.WriteLine("pass");
                return true;
            }
            else
            {
                Console.WriteLine("fail");
                return false;
            }
        }

        private bool normalSelectionSortAscending()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.normal,list);
            SS.sort(eSelection);
            return eSelection.list.SequenceEqual(listAns);
        }

        private bool normalSelectionSortAscendingSortFacade()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.normal,list);
            tsf.sort(eSelection);
            return eSelection.list.SequenceEqual(listAns);
        }
        
        private bool normalSelectionSortDescending()
        {
            eSelection.setParams(SortDirection.descending,Sorts.selectionSort,ArrayType.normal,list);
            SS.sort(eSelection);
            return eSelection.list.SequenceEqual(reverselist);
        }

        private bool normalSelectionSortDecendingSortFacade()
        {
            eSelection.setParams(SortDirection.descending,Sorts.selectionSort,ArrayType.normal,list);
            tsf.sort(eSelection);
            return eSelection.list.SequenceEqual(reverselist);
        }

        public bool reverseSelectionSort()
        {
            Console.WriteLine("running reverse sorted array selction sort");
            bool a, b, c, d;
            a = reverseSelectionSortAscending();
            b = reverseSelectionSortAscendingSortFacade();
            c = reverseSelectionSortDescending();
            d = reverseSelectionSortDescendingSortFacade();
            if (a == true && b == true && c == true && d == true)
            {
                Console.WriteLine("pass");
                return true;
            }
            else
            {
                Console.WriteLine("fail");
                return false;
            }
        }

        private bool reverseSelectionSortAscending()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.reverse,reverselist);
            SS.sort(eSelection);
            return eSelection.list.SequenceEqual(listAns);
        }

        private bool reverseSelectionSortAscendingSortFacade()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.reverse,reverselist);
            tsf.sort(eSelection);
            return eSelection.list.SequenceEqual(listAns);
        }

        private bool reverseSelectionSortDescending()
        {
            eSelection.setParams(SortDirection.descending,Sorts.selectionSort,ArrayType.reverse,reverselist);
            SS.sort(eSelection);
            return eSelection.list.SequenceEqual(reverselist);
        }

        private bool reverseSelectionSortDescendingSortFacade()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.reverse,reverselist);
            SS.sort(eSelection);
            return eSelection.list.SequenceEqual(reverselist);
        }
        
        public bool distinctSelectionSort()
        {
            Console.WriteLine("running distinct array selection sort");
            bool a, b, c, d;
            a = distinctSelectionsortAscending();
            b = distinctSelectionsortAscendingSortFacade();
            c = distinctSelectionsortDescending();
            d = distinctSelectionsortDescendingSortFacade();
            if (a == true && b == true && c == true && d == true)
            {
                Console.WriteLine("pass");
                return true;
            }
            else
            {
                Console.WriteLine("fail");
                return false;
            }
        }

        private bool distinctSelectionsortAscending()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.distinct,distinctlist);
            tsf.sort(eSelection);
            return eSelection.list.SequenceEqual(distinctlistAns);
        }

        private bool distinctSelectionsortAscendingSortFacade()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.distinct,distinctlist);
            SS.sort(eSelection);
            return eSelection.list.SequenceEqual(distinctlistAns);
        }

        private bool distinctSelectionsortDescending()
        {
            eSelection.setParams(SortDirection.descending,Sorts.selectionSort,ArrayType.distinct,distinctlist);
            SS.sort(eSelection);
            return eSelection.list.SequenceEqual(descendingDistinctlistAns);
        }

        private bool distinctSelectionsortDescendingSortFacade()
        {
            eSelection.setParams(SortDirection.descending,Sorts.selectionSort,ArrayType.distinct,distinctlist);
            tsf.sort(eSelection);
            return eSelection.list.SequenceEqual(descendingDistinctlistAns);
        }

        public bool normalInsertionSort()
        {
            Console.WriteLine("running normal array insertion sort");
            bool a, b, c, d;
            a = normalInerstionSortAscending();
            b = normalInerstionSortAscendingSortfacade();
            c = normalInerstionSortDescending();
            d = normalInerstionSortDescendingSortfacade();
            if (a == true && b == true && c == true && d == true)
            {
                Console.WriteLine("pass");
                return true;
            }
            else
            {
                Console.WriteLine("fail");
                return false;
            }
        }

        private bool normalInerstionSortAscending()
        {
            eInserstion.setParams(SortDirection.ascending,Sorts.insertionSort,ArrayType.normal,list);
            IS.sort(eInserstion);
            return eInserstion.list.SequenceEqual(listAns);
        }

        private bool normalInerstionSortAscendingSortfacade()
        {
            eInserstion.setParams(SortDirection.ascending,Sorts.insertionSort,ArrayType.normal,list);
            tsf.sort(eInserstion);
            return eInserstion.list.SequenceEqual(listAns);
        }

        private bool normalInerstionSortDescending()
        {
            eInserstion.setParams(SortDirection.descending,Sorts.insertionSort,ArrayType.normal,list);
            IS.sort(eInserstion);
            return eInserstion.list.SequenceEqual(reverselist);
        }

        private bool normalInerstionSortDescendingSortfacade()
        {
            eInserstion.setParams(SortDirection.descending,Sorts.insertionSort,ArrayType.normal,list);
            tsf.sort(eInserstion);
            return eInserstion.list.SequenceEqual(reverselist);
        }

        public bool reverseInsertionSort()
        {
            Console.WriteLine("running reverse sorted array insertion sort");
            bool a, b, c, d;
            a = reverseInerstionSortAscending();
            b = reverseInerstionSortAscendingSortfacade();
            c = reverseInerstionSortDescending();
            d = reverseInerstionSortDescendingSortfacade();
            if (a == true && b == true && c == true && d == true)
            {
                Console.WriteLine("pass");
                return true;
            }
            else
            {
                Console.WriteLine("fail");
                return false;
            }
        }

        private bool reverseInerstionSortAscending()
        {
            eInserstion.setParams(SortDirection.ascending,Sorts.insertionSort,ArrayType.reverse,reverselist);
            IS.sort(eInserstion);
            return eInserstion.list.SequenceEqual(listAns);
        }

        private bool reverseInerstionSortAscendingSortfacade()
        {
            eInserstion.setParams(SortDirection.ascending,Sorts.insertionSort,ArrayType.reverse,reverselist);
            tsf.sort(eInserstion);
            return eInserstion.list.SequenceEqual(listAns);
        }

        private bool reverseInerstionSortDescending()
        {
            eInserstion.setParams(SortDirection.descending,Sorts.insertionSort,ArrayType.reverse,reverselist);
            IS.sort(eInserstion);
            return eInserstion.list.SequenceEqual(reverselist);
        }

        private bool reverseInerstionSortDescendingSortfacade()
        {
            eInserstion.setParams(SortDirection.descending,Sorts.insertionSort,ArrayType.reverse,reverselist);
            tsf.sort(eInserstion);
            return eInserstion.list.SequenceEqual(reverselist);
        }

        private bool distinctInsertionSort()
        {
            Console.WriteLine("running distinct array insertion sort");
            bool a, b, c, d;
            a = distinctInerstionSortAscending();
            b = distinctInerstionSortAscendingSortfacade();
            c = distinctInerstionSortDescending();
            d = distinctInerstionSortDescendingSortfacade();
            if (a == true && b == true && c == true && d == true)
            {
                Console.WriteLine("pass");
                return true;
            }
            else
            {
                Console.WriteLine("fail");
                return false;
            }
        }
        
       private bool distinctInerstionSortAscending()
        {
            eInserstion.setParams(SortDirection.ascending,Sorts.insertionSort,ArrayType.distinct,distinctlist);
            IS.sort(eInserstion);
            return eInserstion.list.SequenceEqual(distinctlistAns);
        }

        private bool distinctInerstionSortAscendingSortfacade()
        {
            eInserstion.setParams(SortDirection.ascending,Sorts.insertionSort,ArrayType.distinct,distinctlist);
            tsf.sort(eInserstion);
            return eInserstion.list.SequenceEqual(distinctlistAns);
        }

        private bool distinctInerstionSortDescending()
        {
            eInserstion.setParams(SortDirection.descending,Sorts.insertionSort,ArrayType.distinct,distinctlist);
            IS.sort(eInserstion);
            return eInserstion.list.SequenceEqual(descendingDistinctlistAns);
        }

        private bool distinctInerstionSortDescendingSortfacade()
        {
            eInserstion.setParams(SortDirection.descending,Sorts.insertionSort,ArrayType.distinct,distinctlist);
            tsf.sort(eInserstion);
            return eInserstion.list.SequenceEqual(descendingDistinctlistAns);
        }

        public bool normalShellSort()
        {
            Console.WriteLine("running normal array shell sort");
            bool a, b, c, d;
            a = normalShellsortAscending();
            b = normalShellsortAscendingSortFacade();
            c = normalShellsortDecending();
            d = normalShellsortDescendingSortFacade();
            if (a == true && b == true && c == true && d == true)
            {
                Console.WriteLine("pass");
                return true;
            }
            else
            {
                Console.WriteLine("fail");
                return false;
            }
        }

        private bool normalShellsortAscending()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.normal,GapType.hibbard,list);
            SHS.sort(eShell);
            return eShell.list.SequenceEqual(listAns);
        }

        private bool normalShellsortAscendingSortFacade()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.normal,GapType.hibbard,list);
            tsf.sort(eShell);
            return eShell.list.SequenceEqual(listAns);
        }

        private bool normalShellsortDecending()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.normal,GapType.hibbard,list);
            SHS.sort(eShell);
            return eShell.list.SequenceEqual(reverselist);
        }

        private bool normalShellsortDescendingSortFacade()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.normal,GapType.hibbard,list);
            tsf.sort(eShell);
            return eShell.list.SequenceEqual(reverselist);
        }

        public bool reverseShellSort()
        {
            Console.WriteLine("running reverse sorted array shell sort");
            bool a, b, c, d;
            a = reverseShellsortAscending();
            b = reverseShellsortAscendingSortFacade();
            c = reverseShellsortDecending();
            d = reverseShellsortDescendingSortFacade();
            if (a == true && b == true && c == true && d == true)
            {
                Console.WriteLine("pass");
                return true;
            }
            else
            {
                Console.WriteLine("fail");
                return false;
            }
        }

        private bool reverseShellsortAscending()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.reverse,GapType.hibbard,reverselist);
            SHS.sort(eShell);
            return eShell.list.SequenceEqual(listAns);
        }

        private bool reverseShellsortAscendingSortFacade()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.reverse,GapType.hibbard,reverselist);
            tsf.sort(eShell);
            return eShell.list.SequenceEqual(listAns);
        }

        private bool reverseShellsortDecending()
        {
            eShell.setParams(SortDirection.descending,Sorts.shellSort,ArrayType.reverse,GapType.hibbard,reverselist);
            SHS.sort(eShell);
            return eShell.list.SequenceEqual( reverselist);
        }

        private bool reverseShellsortDescendingSortFacade()
        {
            eShell.setParams(SortDirection.descending,Sorts.shellSort,ArrayType.reverse,GapType.hibbard,reverselist);
            tsf.sort(eShell);
            return eShell.list.SequenceEqual(reverselist);
        }

        public bool distinctShellSort()
        {
            Console.WriteLine("running distinct array shell sort");
            bool a, b, c, d;
            a = distinctShellsortAscending();
            b = distinctShellsortAscendingSortFacade();
            c = distinctShellsortDecending();
            d = distinctShellsortDescendingSortFacade();
            if (a == true && b == true && c == true && d == true)
            {
                Console.WriteLine("pass");
                return true;
            }
            else
            {
                Console.WriteLine("fail");
                return false;
            }
        }

        private bool distinctShellsortAscending()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.distinct,GapType.hibbard,distinctlist);
            SHS.sort(eShell);
            return eShell.list.SequenceEqual(distinctlistAns);
        }

        private bool distinctShellsortAscendingSortFacade()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.distinct,GapType.hibbard,distinctlist);
            tsf.sort(eShell);
            return eShell.list.SequenceEqual(distinctlistAns);
        }

        private bool distinctShellsortDecending()
        {
            eShell.setParams(SortDirection.descending,Sorts.shellSort,ArrayType.distinct,GapType.hibbard,distinctlist);
            SHS.sort(eShell);
            return eShell.list.SequenceEqual(descendingDistinctlistAns);
        }

        private bool distinctShellsortDescendingSortFacade()
        {
            eShell.setParams(SortDirection.descending,Sorts.shellSort,ArrayType.distinct,GapType.hibbard,distinctlist);
            tsf.sort(eShell);
            return eShell.list.SequenceEqual(descendingDistinctlistAns);
        }
    }
}
