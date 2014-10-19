using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class ShellSort : Sort
    {
        public ShellSort()
        {

        }

        public void sort(ExperimentParams e)
        {
            int listSize = e.list.Length;
            foreach(int gap in e.gapSequence)
            {
                for (int i = 1; i < listSize; i++)
                {
                    int val = e.list[i];
                    int j = i - gap;
                    while (j > 0 && e.list[j - 1] > val)
                    {
                        e.list[j] = e.list[j - 1];
                        j -= gap;
                    }
                    e.list[j + gap] = val;
                }
            }
        }

        public void printList(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
