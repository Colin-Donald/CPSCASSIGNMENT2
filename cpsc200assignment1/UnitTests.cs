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
        private int[] list = new int[];
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

        public void selectionTest()
        {
            normalSelectionSort();
            reverseSelectionSort();
            distinctSelectionSort();
        }

        public void insertionTest()
        {
            normalinsertionSort();
            reverseinsertionSort();
            distinctinsertionSort();
        }

        public void shellTest()
        {
            normalShellSort();
            reverseShellSort();
            distinctShellSort();
        }

        public bool normalSelectionSort()
        {
            normalSelectionSortAscending();
            normalSelectionSortAscendingSortFacade();
            normalSelectionSortDescending();
            normalSelectionSortDecendingSortFacade();
            return true;
        }

        public bool normalSelectionSortAscending()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.normal,list);
            SS.sort(eSelection);
            return true;
        }

        public bool normalSelectionSortAscendingSortFacade()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.normal,list);
            tsf.sort(eSelection);
            return true;
        }
        
        public bool normalSelectionSortDescending()
        {
            eSelection.setParams(SortDirection.descending,Sorts.selectionSort,ArrayType.normal,list);
            SS.sort(eSelection);
            return true;
        }

        public bool normalSelectionSortDecendingSortFacade()
        {
            eSelection.setParams(SortDirection.descending,Sorts.selectionSort,ArrayType.normal,list);
            tsf.sort(eSelection);
            return true;
        }
        //
        //
        public bool reverseSelectionSort()
        {
            reverseSelectionSortAscending();
            reverseSelectionSortAscendingSortFacade();
            return true;
        }

        public bool reverseSelectionSortAscending()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.reverse,list);
            SS.sort(eSelection);
            return true;
        }

        public bool reverseSelectionSortAscendingSortFacade()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.reverse,list);
            SS.sort(eSelection);
            return true;
        }

        public bool reverseSelectionSortDescending()
        {
            return true;
        }

        public bool reverseSelectionSortDescendingSortFacade()
        {
            return true;
        }

        public bool distinctSelectionSort()
        {
            eSelection.setParams(SortDirection.ascending,Sorts.selectionSort,ArrayType.distinct,list);
            tsf.sort(eSelection);
            eSelection.setParams(SortDirection.descending,Sorts.selectionSort,ArrayType.distinct,list);
            tsf.sort(eSelection);
            return true;
        }

        public bool normalinsertionSort()
        {
            eInserstion.setParams(SortDirection.ascending,Sorts.insertionSort,ArrayType.normal,list);
            tsf.sort(eInserstion);
            eInserstion.setParams(SortDirection.descending,Sorts.insertionSort,ArrayType.normal,list);
            tsf.sort(eInserstion);
            return true;
        }

        public bool reverseinsertionSort()
        {
            eInserstion.setParams(SortDirection.ascending,Sorts.insertionSort,ArrayType.reverse,list);
            tsf.sort(eInserstion);
            eInserstion.setParams(SortDirection.descending,Sorts.insertionSort,ArrayType.reverse,list);
            tsf.sort(eInserstion);
            return true;
        }

        public bool distinctinsertionSort()
        {
            eInserstion.setParams(SortDirection.ascending,Sorts.insertionSort,ArrayType.distinct,list);
            tsf.sort(eInserstion);
            eInserstion.setParams(SortDirection.descending,Sorts.insertionSort,ArrayType.distinct,list);
            tsf.sort(eInserstion);
            return true;
        }

        public bool normalShellSort()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.normal,list);
            tsf.sort(eShell);
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.normal,list);
            tsf.sort(eShell);
            return true;
        }

        public bool reverseShellSort()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.reverse,list);
            tsf.sort(eShell);
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.reverse,list);
            tsf.sort(eShell);
            return true;
        }

        public bool distinctShellSort()
        {
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.distinct,list);
            tsf.sort(eShell);
            eShell.setParams(SortDirection.ascending,Sorts.shellSort,ArrayType.distinct,list);
            tsf.sort(eShell);
            return true;
        }
    }
}
