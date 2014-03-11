using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Automation;
using System.Threading;

namespace ExperimentInFormAutomation 
{
    public partial class DatabaseCreationForm : Form 
    {
        public ISearchForServers thisServerSearch;
        public DatabaseCreationForm()
        {
            InitializeComponent();
        }

        private void DatabaseCreationForm_Load(object sender, EventArgs e)
        {
            ISearchForServers serverConnect = new DummyConnection();
            IEnumerable<string> thisServerList = serverConnect.findServers();

            for (int i = 0; i < thisServerList.Count(); i++)
            {
                string listITem = thisServerList.ElementAt(i);
                serverSelectListBox.Items.Add(listITem);
            }
                
            

            
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("C:\\Users\\chris.gilholm\\Documents\\GitHub\\ChrisCode\\testUINavigation\\testUINavigation\\bin\\Debug\\testUINavigation.exe");
            AutomationElement aeDesktop = AutomationElement.RootElement;

            AutomationElement aeForm = null; int numWaits = 0;
            do
            {
                aeForm = aeDesktop.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.NameProperty, "Test UI Automation"));
                ++numWaits; Thread.Sleep(100);
            }
            while (aeForm == null && numWaits < 50);
            if (aeForm == null) throw new Exception("Failed to find Test UI Automation");

            AutomationElement aeText = aeForm.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit));

            ValuePattern vpTextBox = (ValuePattern)aeText.GetCurrentPattern(ValuePattern.Pattern);
            vpTextBox.SetValue("Holy Cow, it worked!!");

            AutomationElement aeCalendar = aeForm.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.AutomationIdProperty, "testDateTimePicker"));
            aeCalendar.SetFocus();
            ValuePattern getCalendarValue = (ValuePattern)aeCalendar.GetCurrentPattern(ValuePattern.Pattern);
            //getCalendarValue.SetValue("01/01/2013 09:32");
            //getCalendarValue.Current.Value = "01/01/2013";
            
        }  
      

        private void databaseCreateButton_Click(object sender, EventArgs e)
        {

        }

    }
}
