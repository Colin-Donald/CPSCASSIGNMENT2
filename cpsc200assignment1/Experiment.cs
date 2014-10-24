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
        private FileIO FileIO;
        public Experiment()
        {
            ep = new ExperimentParams();
            sf = new SortFacade();
            FileIO = new FileIO();
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
            ep.setParams(arraySize,SortDirection.ascending,Sorts.selectionSort,ArrayType.normal);
            while(arraySize <= 150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                    FileIO.results(ep);
                }
                arraySize += 5000;
            }
            FileIO.printResults();
        }

        public void runExperiment2()
        {
            int arraySize = 5000;
            ep.setParams(arraySize, SortDirection.ascending, Sorts.selectionSort, ArrayType.reverse);
            while (arraySize <= 150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                    FileIO.results(ep);
                }
                arraySize += 5000;
            }
            FileIO.printResults();
        }

        public void runExperiment3()
        {
            int arraySize = 5000;
            ep.setParams(arraySize, SortDirection.ascending, Sorts.selectionSort, ArrayType.distinct);
            while (arraySize <= 150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                    FileIO.results(ep);
                }
                arraySize += 5000;
            }
            FileIO.printResults();
        }

        public void runExperiment4()
        {
            int arraySize = 5000;
            ep.setParams(arraySize, SortDirection.ascending, Sorts.insertionSort, ArrayType.normal);
            while (arraySize <= 150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                    FileIO.results(ep);
                }
                arraySize += 5000;
            }
            FileIO.printResults();
        }

        public void runExperiment5()
        {
            int arraySize = 5000;
            ep.setParams(arraySize, SortDirection.ascending, Sorts.insertionSort, ArrayType.reverse);
            while (arraySize <= 150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                    FileIO.results(ep);
                }
                arraySize += 5000;
            }
            FileIO.printResults();
        }

        public void runExperiment6()
        {
            int arraySize = 5000;
            ep.setParams(arraySize, SortDirection.ascending, Sorts.insertionSort, ArrayType.distinct);
            while (arraySize <= 150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                    FileIO.results(ep);
                }
                arraySize += 5000;
            }
            FileIO.printResults();
        }

        public void runExperiment7()
        {
            FileIO.createExperimentFile();
            int arraySize = 5000;
            ep.setParams(arraySize, SortDirection.ascending, Sorts.shellSort, ArrayType.normal, GapType.hibbard);
            while (arraySize <= 150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                    FileIO.results(ep);
                }
                arraySize += 5000;
            }
            FileIO.printResults();
        }

        public void runExperiment8()
        {
            int arraySize = 5000;
            ep.setParams(arraySize, SortDirection.ascending, Sorts.shellSort, ArrayType.reverse, GapType.hibbard);
            while (arraySize <= 150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                    FileIO.results(ep);
                }
                arraySize += 5000;
            }
            FileIO.printResults();
        }

        public void runExperiment9()
        {
            int arraySize = 5000;
            ep.setParams(arraySize, SortDirection.ascending, Sorts.shellSort, ArrayType.distinct, GapType.hibbard);
            while (arraySize <= 150000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize);
                    sf.sort(ep);
                    FileIO.results(ep);
                }
                arraySize += 5000;
            }
            FileIO.printResults();
        }

        /*public void runExperiment10()
        {
            int arraySize = 10000;
            ep.setParams(arraySize, SortDirection.ascending, Sorts.shellSort, ArrayType.normal);
            while (arraySize <= 1000000)
            {
                for (int j = 0; j < 3; j++)
                {
                    switch (j) 
                    {
                        case 0:
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                ep.setParams(arraySize, GapType.knuth);
                                sf.sort(ep);
                                FileIO.results(ep);
                            }
                            break;
                        }
                        case 1:
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                
                                ep.setParams(arraySize, GapType.hibbard);
                                sf.sort(ep);
                                FileIO.results(ep);
                            }
                            break;
                        }
                        case 2:
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                ep.setParams(arraySize, GapType.tokuda);
                                sf.sort(ep);
                                FileIO.results(ep);
                            }
                            break;
                        }

                    }
                    
                }
                arraySize += 10000;
            }
            FileIO.printResults();
        }*/

        public void runExperiment10()
        {
            int arraySize = 10000;
            ep.setParams(arraySize, SortDirection.ascending, Sorts.shellSort, ArrayType.normal);
            while (arraySize <= 1000000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize, GapType.knuth);
                    sf.sort(ep);
                    FileIO.results(ep);
                }
                arraySize += 10000;
            }
            arraySize = 10000;
            while (arraySize <= 1000000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize, GapType.hibbard);
                    sf.sort(ep);
                    FileIO.results(ep);
                }
                arraySize += 10000;
            }
            arraySize = 10000;
            while (arraySize <= 1000000)
            {
                for (int i = 0; i < 10; i++)
                {
                    ep.setParams(arraySize, GapType.tokuda);
                    sf.sort(ep);
                    FileIO.results(ep);
                }
                arraySize += 10000;
            }


        }

        public void setFile(string s)
        {
            FileIO.fileName = s;
        }
    }
}
