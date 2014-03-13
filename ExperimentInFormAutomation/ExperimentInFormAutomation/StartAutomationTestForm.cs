using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Forms;
using System.Diagnostics;

namespace ExperimentInFormAutomation
{
    class StartAutomationTestForm:ILaunchApplications
    {
        public void LaunchTestUINavigation()
        {
           Process p = Process.Start("C:\\Users\\chris\\Documents\\GitHub\\ChrisCode\\testUINavigation\\testUINavigation\\bin\\Debug\\testUINavigation.exe");
           
        }
    }
}
