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
            ep.setParams(arraySize,true,Sorts.selectionSort);
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
            ep.setParams(arraySize, true, Sorts.selectionSort);
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
            ep.setParams(arraySize, true, Sorts.selectionSort);
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
            ep.setParams(arraySize, true, Sorts.insertionSort);
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
            ep.setParams(arraySize, true, Sorts.insertionSort);
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
            ep.setParams(arraySize, true, Sorts.insertionSort);
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
            ep.setParams(arraySize, true, Sorts.shellSort);
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
            ep.setParams(arraySize, true, Sorts.shellSort);
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
            ep.setParams(arraySize, true, Sorts.shellSort);
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
            ep.setParams(arraySize, true, Sorts.shellSort , GapType.knuth);
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
    }
}
