using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class FileIO
    {
        private String FilePath;
        private String FileName;
        public String fileName
        {
            set { FileName = value; }
        }
        private String delimiter;
        StreamWriter sw;
        private String s;
        private long[] averageTime = new long[10];
        private int[] averageMem = new int[10];
        public FileIO()
        {
            this.FileName = @"\experimental_results";
            this.delimiter = ",";
        }

        public void createExperimentFile()
        {
            using (File.Create(FileName)) { }
        }

        public void averageTimeMem(int i,ExperimentParams e)
        {
            averageTime[i] = e.runTime;
            averageMem[i] = e.memory;
        }

        public void results(ExperimentParams e)
        {
            long runTime = 0;
            int memory = 0;
            for(int i = 0; i < 10; i++)
            {
                runTime += averageTime[i];
                memory += averageMem[i];
            }
            runTime /= 10;
            memory /= 10;

            s = e.s.sortType.ToString() + delimiter + e.s.sortDirection.ToString() + delimiter + e.arrayType.ToString() + delimiter
                + e.s.gapType.ToString() + delimiter + e.arraySize + delimiter + e.arrayCheck + delimiter + memory + delimiter + runTime + delimiter; 
            using(sw = new StreamWriter(FileName,true)){
                sw.WriteLine(s);
            }
        }

        public void printResults()
        {  
                sw.Close();  
        }
    }
}