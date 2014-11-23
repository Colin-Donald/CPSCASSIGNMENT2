using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    public class TestExperimentParams
    {
        private int ArraySize;
        public int arraySize
        {
            get { return ArraySize; }
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
        private TestSortParams tSP;
        public TestSortParams tsp
        {
            get { return tSP; }
        }
        private int[] List;
        public int[] list
        {
            get{ return List; }
            set { List = value; }
        }

        public TestExperimentParams()
        {
            ArraySize = 0;
            tSP = new TestSortParams();
            tsp.sortDirection = SortDirection.ascending;
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
            tsp.gapSequence = TestGapSeq.GapSequence(GapType, ArraySize);
            List = GenArray.genArray(ArraySize,list);
        }

        public void setParams(SortDirection sortDirection, Sorts sorts, ArrayType arrayType,int[] list )
        {
            ArraySize = arraySize;
            tsp.sortDirection = sortDirection;
            tsp.sortType = sorts;
            aT = arrayType;
            List = list;
            //List = GenArray.genArray(arrayType, ArraySize);
        }

        public void setParams(SortDirection sortDirection, Sorts sorts, ArrayType arrayType , GapType gapType, int[] list)
        {
            ArraySize = arraySize;
            tsp.sortDirection = sortDirection;
            tsp.sortType = sorts;
            aT = arrayType;
            tsp.gapSequence = TestGapSeq.GapSequence(gapType,list.Length);
            List = list;
            //List = GenArray.genArray(ArraySize);
        }
    }
}
