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
        private ExperimentParams eShell;
        private ExperimentParams eSelection;
        private ExperimentParams eInserstion;
        public UnitTests()
        {
            eShell = new ExperimentParams();
            eSelection = new ExperimentParams();
            eInserstion = new ExperimentParams();
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
            return true;
        }

        public bool reverseSelectionSort()
        {
            return true;
        }

        public bool distinctSelectionSort()
        {
            return true;
        }

        public bool normalinsertionSort()
        {
            return true;
        }

        public bool reverseinsertionSort()
        {
            return true;
        }

        public bool distinctinsertionSort()
        {
            return true;
        }

        public bool normalShellSort()
        {
            return true;
        }

        public bool reverseShellSort()
        {
            return true;
        }

        public bool distinctShellSort()
        {
            return true;
        }
    }
}
