using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class InsertionSort : Sort
    {
        public InsertionSort()
        {
            
        }

        public void sort(int[] list)
        {
            int listSize = list.Length;
            for(int i = 1; i < listSize; i++)
            {
                int val = list[i];
                int j = i;
                while (j > 0 && list[j - 1] > val)
                {
                    list[j] = list[j - 1];
                    j--;
                }
                list[j] = val;
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
