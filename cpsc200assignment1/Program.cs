using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    public enum Sorts { insertionSort, selectionSort, shellSort }
    public enum GapType {knuth, hibbard, tokuda }
    public enum SortDirection { normal , reverse}
    public enum ArrayType { normal, distinct}
    class Program
    {
        public Program()
        {

        }

        static void Main(string[] args)
        {
            ExperimentFacade e = new ExperimentFacade();
            e.experimentUI();
        }       
    }
}
