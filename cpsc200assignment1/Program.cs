using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace cpsc200assignment1
{
    public enum Sorts { insertionSort, selectionSort, shellSort, mergeSort, quickSort }
    public enum GapType {knuth, hibbard, tokuda }
    public enum SortDirection { ascending, descending}
    public enum ArrayType { normal, reverse, distinct}
    public class Program
    {
        static void Main(string[] args)
        {
            ExperimentFacade e = new ExperimentFacade();
            e.experimentUI();
        }
    }
}
