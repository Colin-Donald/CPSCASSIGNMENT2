using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class TestSortFacade
    {
        private TestInsertionSort IS;
        private TestSelectionSort SS;
        private TestShellSort SHS;

        public TestSortFacade()
        {
            IS = new TestInsertionSort();
            SS = new TestSelectionSort();
            SHS = new TestShellSort();
        }

        public void sort(TestExperimentParams e)
        {
            
            switch (e.sortType)
            {
                case Sorts.insertionSort:
                {
                    TestSort jSort = (TestSort)IS;
                    jSort.sort(e);
                    break;
                }
                case Sorts.selectionSort:
                {
                    TestSort kSort = (TestSort)SS;
                    kSort.sort(e);
                    break;
                }
                case Sorts.shellSort:
                {
                    TestSort lSort = (TestSort)SHS;
                    lSort.sort(e);
                    break;
                }
                default :
                {
                    break;
                }
            }
        }
    }
}
