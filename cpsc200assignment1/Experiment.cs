using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class Experiment
    {
        private ExperimentParams ep;
        private SortFacade sf;
        public Experiment()
        {
            ep = new ExperimentParams();
            sf = new SortFacade();
        }
       

        public void runAllExperiment()
        {
            runExperiment1();
            runExperiment2();
            runExperiment3();
            runExperiment4();
            runExperiment5();
            runExperiment6();
            runExperiment7();
            runExperiment8();
            runExperiment9();
            runExperiment10();
        }

        public void runExperiment1()
        {
            int arraySize = 5000;
            ep.setParams(arraySize,SortDirection.normal,Sorts.selectionSort, ArrayType.normal);
            while(arraySize<150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                }
                arraySize += 5000;
            }
        }

        public void runExperiment2()
        {
            int arraySize = 5000;
            ep.setParams(arraySize, SortDirection.reverse, Sorts.selectionSort, ArrayType.normal);
            while (arraySize < 150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                }
                arraySize += 5000;
            }
        }

        public void runExperiment3()
        {
            int arraySize = 5000;
            ep.setParams(arraySize, SortDirection.normal, Sorts.selectionSort, ArrayType.distinct);
            while (arraySize < 150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                }
                arraySize += 5000;
            }
        }

        public void runExperiment4()
        {
            int arraySize = 5000;
            ep.setParams(arraySize, SortDirection.normal, Sorts.insertionSort, ArrayType.normal);
            while (arraySize < 150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                }
                arraySize += 5000;
            }
        }

        public void runExperiment5()
        {
            int arraySize = 5000;
            ep.setParams(arraySize, SortDirection.reverse, Sorts.insertionSort, ArrayType.normal);
            while (arraySize < 150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                }
                arraySize += 5000;
            }
        }

        public void runExperiment6()
        {
            int arraySize = 5000;
            ep.setParams(arraySize, SortDirection.normal, Sorts.insertionSort, ArrayType.distinct);
            while (arraySize < 150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                }
                arraySize += 5000;
            }
        }

        public void runExperiment7()
        {
            int arraySize = 5000;
            ep.setParams(arraySize, SortDirection.normal, Sorts.shellSort, ArrayType.normal);
            while (arraySize < 150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                }
                arraySize += 5000;
            }
        }

        public void runExperiment8()
        {
            int arraySize = 5000;
            ep.setParams(arraySize, SortDirection.reverse, Sorts.shellSort, ArrayType.normal);
            while (arraySize < 150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                }
                arraySize += 5000;
            }
        }

        public void runExperiment9()
        {
            int arraySize = 5000;
            ep.setParams(arraySize, SortDirection.normal, Sorts.shellSort, ArrayType.distinct);
            while (arraySize < 150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                }
                arraySize += 5000;
            }
        }

        public void runExperiment10()
        {
            int arraySize = 5000;
            ep.setParams(arraySize, SortDirection.normal, Sorts.shellSort, ArrayType.normal);
            while (arraySize < 150000)
            {
                for (int j = 0; j < 3; j++)
                {
                    switch (j) 
                    {
                        case 0:
                        {
                            ep.setParams(GapType.knuth);
                            for (int i = 0; i < 10; i++)
                            {
                                ep.setParams(arraySize);
                                sf.sort(ep);
                            }
                            break;
                        }
                        case 1:
                        {
                            ep.setParams(GapType.pratt);
                            for (int i = 0; i < 10; i++)
                            {
                                ep.setParams(arraySize);
                                sf.sort(ep);
                            }
                            break;
                        }
                        case 2:
                        {
                            ep.setParams(GapType.tokuda);
                            for (int i = 0; i < 10; i++)
                            {
                                ep.setParams(arraySize);
                                sf.sort(ep);
                            }
                            break;
                        }

                    }
                    
                }
                arraySize += 5000;
            }
        }
    }
}
