using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class ExperimentParams
    {
        private int ArraySize;
        public int arraySize
        {
            get { return ArraySize; }
        }
        private bool SortDirection;
        public bool sortDirection
        {
            get { return SortDirection; }
        }
        private Sorts SortType;
        public Sorts sortType
        {
            get { return SortType; }
        }
        private GenArray GenArray;
        public int[] list;
        private int[] gapSequence;

        public ExperimentParams()
        {
            ArraySize = 0;
            SortDirection = true;
            GenArray = new GenArray();
        }

        public void setParams(int arraySize)
        {
            ArraySize = arraySize;
            list = GenArray.genArray(ArraySize);
        }

        public void setParams(int arraySize, Boolean sortDirection, Sorts sorts )
        {
            ArraySize = arraySize;
            SortDirection = sortDirection;
            SortType = sorts;
            list = GenArray.genArray(ArraySize);
        }

        public void setParams(int arraySize, Boolean sortDirection, Sorts sorts, GapType gapType)
        {
            ArraySize = arraySize;
            SortDirection = sortDirection;
            SortType = sorts;
            gapSequence = GapSeq.GapSequence(gapType);
            list = GenArray.genArray(ArraySize);
        }
    }
}
