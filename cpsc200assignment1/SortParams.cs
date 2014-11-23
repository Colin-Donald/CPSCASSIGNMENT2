using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class SortParams
    {
        private SortDirection sD;
        public SortDirection sortDirection
        {
            get { return sD; }
            set { sD = value; }
        }
        private Sorts SortType;
        public Sorts sortType
        {
            get { return SortType; }
            set { SortType = value; }
        }
        private int[] GapSequence;
        public int[] gapSequence
        {
            get { return GapSequence; }
            set { GapSequence = value; }
        }
        private GapType GapType;
        public GapType gapType
        {
            get { return GapType; }
            set { GapType = value; }
        }
        public SortParams()
        {
            sD = SortDirection.ascending;
        }
    }
}
