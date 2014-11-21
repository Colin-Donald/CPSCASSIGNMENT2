using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class SortFacade
    {
        private InsertionSort IS;
        private SelectionSort SS;
        private ShellSort SHS;

        public SortFacade()
        {
            IS = new InsertionSort();
            SS = new SelectionSort();
            SHS = new ShellSort();
        }

        public void sort(ExperimentParams e)
        {
            
            switch (e.s.sortType)
            {
                case Sorts.insertionSort:
                {
                    Sort jSort = (Sort)IS;
                    jSort.sort(e);
                    break;
                }
                case Sorts.selectionSort:
                {
                    Sort kSort = (Sort)SS;
                    kSort.sort(e);
                    break;
                }
                case Sorts.shellSort:
                {
                    Sort lSort = (Sort)SHS;
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
