using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Diagnostics;
using System.Threading;

namespace ExperimentInFormAutomation
{
    class FindAutomationTestForm
    {
        public static AutomationElement FindAutomationForm()
        {

            Process p = Process.Start("C:\\Users\\chris\\Documents\\GitHub\\ChrisCode\\testUINavigation\\testUINavigation\\bin\\Debug\\testUINavigation.exe");
            AutomationElement aeDesktop = AutomationElement.RootElement;

            AutomationElement aeForm = null; int numWaits = 0;
            do
            {
                aeForm = aeDesktop.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.NameProperty, "Test UI Automation"));
                ++numWaits; Thread.Sleep(100);
            } while (aeForm == null && numWaits < 50);
            if (aeForm == null) throw new Exception("Failed to find Test UI Automation");
            return aeForm;
        }
    }
}
