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
        public FileIO()
        {
            this.FileName = @"\experimental_results";
            this.delimiter = ",";



        }

        public void createExperimentFile()
        {
            using (File.Create(FileName)) { }
        }

        public void results(ExperimentParams e)
        {
            s = e.sortType.ToString() + delimiter + e.sortDirection.ToString() + delimiter + e.arrayType.ToString() + delimiter
                + e.gapType.ToString() + delimiter + e.arraySize + delimiter + e.arrayCheck + delimiter + e.memory + delimiter + e.runTime + delimiter; 
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
