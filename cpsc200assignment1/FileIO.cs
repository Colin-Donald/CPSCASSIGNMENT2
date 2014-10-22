using System;
using System.Collections.Generic;
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
        private String fileName;
        private String fileType;
        private String delimiter;
        private StringBuilder sB;
        private int experimentNumber;

        public FileIO()
        {
            ep = new List<String>();
            this.FilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.fileName = @"\experimental_results";
            this.fileType = ".csv";
            this.delimiter = ",";
            this.experimentNumber = 1;
            sB = new StringBuilder();
        }

        public void results(ExperimentParams e)
        {
            sB.Append(e.sortType.ToString());
            sB.Append(delimiter);
            sB.Append(e.sortDirection.ToString());
            sB.Append(delimiter);
            sB.Append(e.arrayType.ToString());
            sB.Append(delimiter);
            sB.Append(e.gapType.ToString());
            sB.Append(delimiter);
            sB.Append(e.arraySize.ToString());
            sB.Append(delimiter);
            sB.Append(e.arrayCheck);
            sB.Append(delimiter);
            sB.Append(e.memory.ToString());
            sB.Append(delimiter);
            sB.Append(e.runTime.ToString());
            sB.Append(delimiter);
            sB.Append("\n");
            ep.Add(sB.ToString());
        }

        public void printResults()
        {
            int i = 0;
            result = new String[ep.Count];
            foreach (String s in ep)
            {
                result[i] = s;
            }
            System.IO.File.WriteAllLines(FilePath + fileName + experimentNumber + fileType, result);
            experimentNumber++;
        }

    }
}
