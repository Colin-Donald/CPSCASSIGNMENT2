using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class ExperimentFacade
    {
        private Experiment e;
        public ExperimentFacade()
        {
            e = new Experiment();
        }

        public void experimentUI()
        {
            Console.WriteLine("1. experiments");
            Console.WriteLine("2. Unit tests");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        experiment();
                        break;
                    }
                case 2:
                    {
                        unitTests();
                        break;
                    }
                default:
                    {
                        experimentUI();
                        break;
                    }
            }

        }

        private void unitTests()
        {
            int i = int.Parse(Console.ReadLine());
            switch(i)
            {
                case 1:
                {
                    break;
                }
            }
        }

        private void experiment()
        {
            Console.WriteLine("1.   experiment 1");
            Console.WriteLine("2.   experiment 2");
            Console.WriteLine("3.   experiment 3");
            Console.WriteLine("4.   experiment 4");
            Console.WriteLine("5.   experiment 5");
            Console.WriteLine("6.   experiment 6");
            Console.WriteLine("7.   experiment 7");
            Console.WriteLine("8.   experimnet 8");
            Console.WriteLine("9.   experiment 9");
            Console.WriteLine("10.  experiment 10");
            Console.WriteLine("11.  run all experiments");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                {
                    e.runExperiment1();
                    break;
                }
                case 2:
                {
                    e.runExperiment2();
                    break;
                }
                case 3:
                {
                     e.runExperiment3();
                     break;
                }
                case 4:
                {
                    e.runExperiment4();
                    break;
                }
                case 5:
                {
                    e.runExperiment5();
                    break;
                }
                case 6:
                {
                    e.runExperiment6();
                    break;
                }
                case 7:
                {
                     e.runExperiment7();
                     break;
                }
                case 8:
                {
                    e.runExperiment8();
                    break;
                }
                case 9:
                {
                    e.runExperiment9();
                    break;
                }
                case 10:
                {
                    e.runExperiment10();
                    break;
                }
                case 11:
                {
                    e.runAllExperiment();
                    break;
                }
                default:
                {
                    Console.WriteLine("invalid input please try again");
                    experiment();
                    break;
                }
            }
        }
    }
}
