using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsc200assignment1
{
    class FileIO
    {
        private List<ExperimentParams> ep = new List<ExperimentParams>();

        public FileIO()
        {

        }

        public void results(ExperimentParams e)
        {
            ep.Add(e);
        }

    }
}
