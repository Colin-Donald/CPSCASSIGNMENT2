using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using cpsc200assignment1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private int[] list = new int[10] { 10, 5, 3, 6, 7, 2, 4, 8, 1, 9 };
        private int[] reverselist = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        private int[] distinctlist = new int[10] { 0, 4, 3, 2, 2, 1, 4, 5, 3, 2 };
        private int[] listAns = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private int[] distinctlistAns = new int[10] { 0, 1, 2, 2, 2, 3, 3, 4, 4, 5 };
        private int[] descendingDistinctlistAns = new int[10] { 5, 4, 4, 3, 3, 2, 2, 2, 1, 0 };
        private int[] testList;
        private TestExperimentParams e = new TestExperimentParams();
        [TestMethod]
        public void shellSort()
        {
            //setup
            TestShellSort s = new TestShellSort();
            TestSort sSort = (TestSort)s;
            e.setParams(SortDirection.ascending, Sorts.shellSort, ArrayType.normal, GapType.tokuda, list);

            //test
            sSort.sort(e);
            testList = e.list;
            //output
            //Assert.AreEqual(e.tsp.sortDirection, SortDirection.ascending);
            CollectionAssert.AreEqual(listAns, testList);
        }

        [TestMethod]
        public void insertionSort()
        {
            //setup
            TestInsertionSort i = new TestInsertionSort();
            TestSort Sort = (TestSort)i;
            e.setParams(SortDirection.ascending, Sorts.insertionSort, ArrayType.normal, list);

            //test
            Sort.sort(e);

            //output
            CollectionAssert.AreEqual(e.list, listAns);
        }

        [TestMethod]
        public void selectionSort()
        {
            //setup
            TestSelectionSort i = new TestSelectionSort();
            TestSort Sort = (TestSort)i;
            e.setParams(SortDirection.ascending, Sorts.selectionSort, ArrayType.normal, list);

            //test
            Sort.sort(e);

            //Assert
            CollectionAssert.AreEqual(e.list, listAns);
        }
        [TestMethod]
        public void quickSort()
        {
            //setup
            TestQuickSort i = new TestQuickSort();
            TestSort Sort = (TestSort)i;
            e.setParams(SortDirection.ascending, Sorts.quickSort, ArrayType.normal, list);

            //test
            Sort.sort(e);

            //output
            CollectionAssert.AreEqual(e.list, listAns);
        }
        [TestMethod]
        public void quickHybridSort()
        {

        }
        [TestMethod]
        public void mergeSort()
        {

        }
        [TestMethod]
        public void mergeHybridSort()
        {

        }
    }
}
