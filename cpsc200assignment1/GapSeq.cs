using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    public static class GapSeq
    {

       public static int[] GapSequence(GapType gapType, int arraySize)
        {
            switch(gapType)
            {
                case GapType.knuth:
                {
                    return knuthSeq(arraySize);
                }
                case GapType.hibbard:
                {
                    return hibbardSeq(arraySize);
                }
                case GapType.tokuda:
                {
                    return tokudaSeq(arraySize);
                }
                default:
                {
                    return null;
                }
             
            }

        }

        private static int[] knuthSeq(int arraySize)
        {
            int[] knuth = new int[20];
            for (int i = 1; i < 21; i++)
            {
                knuth[i - 1] = ((int)Math.Pow(3, i) - 1) / 2;
            }
            knuth = sort(knuth);
            for (int i = 0; i < 20; i++)
            {
                if(knuth[i] <= arraySize)
                {
                    for (int j = 0; j < 20 - i; j++)
                    {
                        knuth[j] = knuth[i];
                        i++;
                    }
                }
            }
            return knuth;
        }

        private static int[] hibbardSeq(int arraySize)
        {
            int[] hibbard = new int[30];
            for (int i = 1; i < 21; i++)
            {
                hibbard[i - 1] = (int)Math.Pow(2, i) + 1;
            }
            hibbard = sort(hibbard);
            for (int i = 0; i < 30; i++)
            {
                if (hibbard[i] <= arraySize)
                {
                    for (int j = 0; j < 30 - i; j++)
                    {
                        hibbard[j] = hibbard[i];
                        i++;
                    }
                }
            }
            return hibbard;
        }

        private static int[] tokudaSeq(int arraySize)
        {
            int[] tokuda = new int[27];
            for (int i = 1; i < 21; i++)
            {
                tokuda[i - 1] = (int)((Math.Pow(9, i) - Math.Pow(4, i)) / (5 * Math.Pow(4, i - 1)));
            }
            tokuda = sort(tokuda);
            for (int i = 0; i < 27; i++)
            {
                if (tokuda[i] <= arraySize)
                {
                    for (int j = 0; j < 27 - i; j++)
                    {
                        tokuda[j] = tokuda[i];
                        i++;
                    }
                }
            }
            return tokuda;
        }

        private static int[] sort(int[] list)
        {
            int listSize = list.Length;
            int nextPos = 0;
            while (nextPos < listSize)
            {
                int minElement = nextPos;
                for (int i = nextPos + 1; i < listSize; i++)
                {
                    if (list[i] > list[minElement])
                    {
                        minElement = i;
                    }
                }
                int temp = list[minElement];
                list[minElement] = list[nextPos];
                list[nextPos] = temp;
                nextPos++;
            }
            return list;
        }
    }
}
