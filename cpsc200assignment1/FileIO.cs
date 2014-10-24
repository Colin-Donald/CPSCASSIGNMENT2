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
        private List<String> ep;
        private String[] result;
        private String FilePath;
        private String FileName;
        public String fileName
        {
            set { FileName = value; }
        }
        private String fileType;
        private String delimiter;
        private StringBuilder sB;
        private int experimentNumber;
        StreamWriter sw;
        private String s;
        public FileIO()
        {
            this.FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            this.FileName = @"\experimental_results";
            this.fileType = ".csv";
            this.delimiter = ",";
            this.experimentNumber = 1;



        }

        public void createExperimentFile()
        {
            using (File.Create(FileName + fileType)) { }
        }

        public void results(ExperimentParams e)
        {
            s = e.sortType.ToString() + delimiter + e.sortDirection.ToString() + delimiter + e.arrayType.ToString() + delimiter
                + e.gapType.ToString() + delimiter + e.arraySize + delimiter + e.arrayCheck + delimiter + e.memory + delimiter + e.runTime + delimiter; 
            using(sw = new StreamWriter(FilePath + FileName + experimentNumber + fileType,true)){
                sw.WriteLine(s);
            }
        }

        public void printResults()
        {  
                sw.Close();  
        }
    }
}
