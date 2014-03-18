using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ExperimentInFormAutomation
{
    class ActiveFormName
    {
        public string FormName(Process p)
        {
           return p.MainWindowTitle;
        }
    }
}
