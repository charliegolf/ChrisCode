using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ExperimentInFormAutomation
{
    class StartAutomationTestForm:ILaunchApplications
    {
        public Process LaunchTestUINavigation()
        {
            String myLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); 
            String thisStart = Path.Combine(myLocation,  "GitHub", "ChrisCode", "testUINavigation", "testUINavigation", "bin", "Debug", "testUINavigation.exe");
            Process p = Process.Start(thisStart);
            return p;
        }
    }
}
