using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    public static class GapSeq
    {

       public static int[] GapSequence(GapType gapType)
        {
            switch(gapType)
            {
                case GapType.knuth:
                {
                    return knuthSeq();
                }
                case GapType.pratt:
                {
                    return prattSeq();
                }
                default:
                {
                    return null;
                }
             
            }

        }

        private static int[] knuthSeq()
        {
            int[] knuth;
            knuth = null;
            return knuth;
        }

        private static int[] prattSeq()
        {
            int[] pratt;
            pratt = null;
            return pratt;
        }
    }
}
