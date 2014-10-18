﻿using System;
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

        private GenArray GenArray;
        public int[] list;
        private int[] gapSequence;

        public ExperimentParams()
        {
            ArraySize = 0;
            sD = SortDirection.normal;
            GenArray = new GenArray();
        }

        public void setParams(int arraySize)
        {
            ArraySize = arraySize;
            list = GenArray.genArray(ArraySize);
        }



        public void setParams(GapType gapType)
        {
            gapSequence = GapSeq.GapSequence(gapType);
        }

        public void setParams(int arraySize, SortDirection sortDirection, Sorts sorts, ArrayType arrayType )
        {
            ArraySize = arraySize;
            sD = sortDirection;
            SortType = sorts;
            aT = arrayType;
            list = GenArray.genArray(arrayType, ArraySize);
        }

        public void setParams(int arraySize, SortDirection sortDirection, Sorts sorts, ArrayType arrayType , GapType gapType)
        {
            ArraySize = arraySize;
            sD = sortDirection;
            SortType = sorts;
            aT = arrayType;
            gapSequence = GapSeq.GapSequence(gapType);
            list = GenArray.genArray(ArraySize);
        }
    }
}
