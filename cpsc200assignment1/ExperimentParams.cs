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
        private SortDirection sD;
        public  SortDirection sortDirection
        {
            get { return sD; }
        }
        private Sorts SortType;
        public Sorts sortType
        {
            get { return SortType; }
        }
        private ArrayType aT;
        public ArrayType arrayType
        {
            get { return aT; }
        }
        private GapType GapType;
        public GapType gapType
        {
            get { return GapType; }
        }
        private bool ArrayCheck = true;
        public bool arrayCheck
        {
            get { return ArrayCheck; }
            set { ArrayCheck = value; }
        }
        private long runtime;
        public long runTime
        {
            get { return runtime; }
            set {runtime = value; }
        }
        private int Memory;
        public int memory
        {
            get { return Memory; }
            set { Memory = value; }
        }
        private GenArray GenArray;
        private int[] List;
        public int[] list
        {
            get{ return List; }
            set { List = value; }
        }
        private int[] GapSequence;
        public int[] gapSequence
        {
            get { return GapSequence; }
        }

        public ExperimentParams()
        {
            ArraySize = 0;
            sD = SortDirection.ascending;
            GenArray = new GenArray();
        }

        public void setParams(int arraySize)
        {
            ArraySize = arraySize;
            List = GenArray.genArray(ArraySize,list);
        }

        public void setParams(int arraySize, GapType gapType)
        {
            this.GapType = gapType;
            ArraySize = arraySize;
            GapSequence = GapSeq.GapSequence(GapType, ArraySize);
            List = GenArray.genArray(ArraySize,list);
        }

        public void setParams(int arraySize, SortDirection arrayDirection, Sorts sorts, ArrayType arrayType )
        {
            ArraySize = arraySize;
            sD = arrayDirection;
            SortType = sorts;
            aT = arrayType;
            List = GenArray.genArray(arrayType, ArraySize,list);
        }

        public void setParams(int arraySize, SortDirection arrayDirection, Sorts sorts, ArrayType arrayType , GapType gapType)
        {
            ArraySize = arraySize;
            sD = arrayDirection;
            SortType = sorts;
            aT = arrayType;
            GapSequence = GapSeq.GapSequence(gapType,arraySize);
            List = GenArray.genArray(ArraySize,list);
        }
    }
}
