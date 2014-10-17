/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class SortParams
    {
        private int ArraySize;
        public int arraySize
        {
            get{ return ArraySize;}
            set{ this.ArraySize = arraySize;}
        }
        private Boolean sortDirection;
        public Boolean SortDirection    //true is defualt false is reverse direction
        {
            get{ return SortDirection;}
            set{ this.SortDirection = sortDirection;}
        }
        private int SortType;
        public int sortType
        {
            get{ return SortType;}
            private set{ this.SortType = sortType;}
        }
        
       
        
        public SortParams()
        {
            ArraySize = 0;
            SortDirection = true;
            SortType = 0;
           
            
        }

        public void setParams(ExperimentParams e)
        {
            ArraySize = e.arraySize;
            SortDirection = e.sortDirection;
            SortType = e.sortType;
             
        }
    }
}*/
