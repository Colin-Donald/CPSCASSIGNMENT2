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
        private String FilePath;
        private String delimiter;
        private StringBuilder sB;

        public FileIO()
        {
            ep = new List<ExperimentParams>();
            this.FilePath = "C:\test.csv";
            this.delimiter = ",";
            sB = new StringBuilder();
        }

        public void results(ExperimentParams e)
        {
            ep.Add(e);
        }

        public void printResults()
        {

        }

    }
}
