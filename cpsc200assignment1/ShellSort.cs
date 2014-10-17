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

        public void sort(int[] list)
        {
            int[] gapSeq = null;
            int listSize = list.Length;
            foreach(int gap in gapSeq)
            {
                for (int i = 1; i < listSize; i++)
                {
                    int val = list[i];
                    int j = i - gap;
                    while (j > 0 && list[j - 1] > val)
                    {
                        list[j] = list[j - 1];
                        j -= gap;
                    }
                    list[j + gap] = val;
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
