using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class CustomExperiment
    {
        private int arraySize;
        private SortDirection sD;
        private Sorts sortType;
        private ArrayType aT;
        private GapType gapType;
        private ExperimentParams ep;
        private SortFacade sf;
        public CustomExperiment()
        {
            ep = new ExperimentParams();
            sf = new SortFacade();
        }

        public void customExperiment()
        {
            Console.WriteLine("1. selection sort");
            Console.WriteLine("2. insertion sort");
            Console.WriteLine("3. shell sort");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                {
                    sortType = Sorts.selectionSort;
                    break;
                }
                case 2:
                {
                    sortType = Sorts.insertionSort;
                    break;
                }
                case 3:
                {
                    customShell();
                    break;
                }
                default:
                {
                    customExperiment();
                    break;
                }
            }
          
            Console.WriteLine("1. normal array");
            Console.WriteLine("2. reverse array");
            Console.WriteLine("3. distinct array");
            i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        aT = ArrayType.normal;
                        break;
                    }
                case 2:
                    {
                        aT = ArrayType.reverse;
                        break;
                    }
                case 3:
                    {
                        aT = ArrayType.distinct;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid input try again");
                        customExperiment();
                        break;
                    }
            }
            runexperiment();

        }

        private void customShell()
        {
            sortType = Sorts.shellSort;
            Console.WriteLine("1. knuth");
            Console.WriteLine("2. hibbard");
            Console.WriteLine("3. tokudo");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                {
                    gapType = GapType.knuth;
                    break;
                }
                case 2:
                {
                    gapType = GapType.hibbard;
                    break;
                }
                case 3:
                {
                    gapType = GapType.tokuda;
                    break;
                }
                default:
                {
                    Console.WriteLine("invalid input try again");
                    customExperiment();
                    break;
                }
            }
        }

        private void runexperiment()
        {
            ep.setParams(arraySize, SortDirection.ascending, sortType, aT, gapType);
            sf.sort(ep);
            Console.WriteLine(ep.runTime);
            Console.WriteLine(ep.memory);
            Console.WriteLine(ep.arrayCheck);
        }
    }
}
