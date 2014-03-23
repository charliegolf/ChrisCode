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
            ILaunchApplications Launch = new StartAutomationTestForm();
            Process p = Launch.LaunchTestUINavigation();

            Process FormProcess = Launch.GetProcess(p);
                                 
            FindProcessID ProcessID = new FindProcessID();
            int pID = ProcessID.FindFormProcessID(FormProcess);

            FindApplication Find = new FindApplication();

            AutomationElement FindForm = Find.FindForm();

            AutomateTextBox TextBox = new AutomateTextBox();
            TextBox.AutomateThisTextBox(FindForm);

            AutomateListBox ListBox = new AutomateListBox();
            ListBox.AutomateThisListBox(FindForm, 3);

            AutomateCalendar thisCalendar = new AutomateCalendar();
            thisCalendar.AutomateDatePicker(FindForm, pID, p);
        
         }  
    }
}
