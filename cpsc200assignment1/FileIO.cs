using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class FileIO
    {
        private List<ExperimentParams> ep;
        private String[] result;
        private String FilePath;
        private String fileName;
        private String delimiter;
        private StringBuilder sB;

        public FileIO()
        {
            ep = new List<ExperimentParams>();
            this.FilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.fileName = @"\experimental_results.csv";
            this.delimiter = ",";
            sB = new StringBuilder();
        }

        public void results(ExperimentParams e)
        {
            ExperimentParams copy = e;
            ep.Add(copy);
        }

        public void printResults()
        {
            int i = 0;
            result = new string[ep.Count];
            foreach (ExperimentParams e in ep)
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
                sB.Append(e.memory.ToString());
                sB.Append(delimiter);
                sB.Append(e.runTime.ToString());
                sB.Append(delimiter);
                result[i]= sB.ToString();
                i++;
            }

            System.IO.File.WriteAllLines(FilePath + fileName,result);
            
        }

    }
}
