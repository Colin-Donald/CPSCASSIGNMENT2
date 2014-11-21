using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using cpsc200assignment1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private int[] list = new int[10] { 10, 5, 3, 6, 7, 2, 4, 8, 1, 9 };

        private TestExperimentParams e;
        [TestMethod]
        public void shellSort()
        {
            TestShellSort s = new TestShellSort();
            TestSort sSort = (TestSort)s;
        }

        [TestMethod]
        public void insertionSort()
        {

        }

        [TestMethod]
        public void selectionSort()
        {

        }
        [TestMethod]
        public void quickSort()
        {

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
