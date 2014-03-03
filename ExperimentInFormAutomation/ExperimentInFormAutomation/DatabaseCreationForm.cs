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
            Process p = Process.Start("C:\\Users\\chris\\Documents\\GitHub\\ChrisCode\\testUINavigation\\testUINavigation\\bin\\Debug\\testUINavigation.exe");
            AutomationElement aeDesktop = AutomationElement.RootElement;

            AutomationElement aeForm = null; int numWaits = 0;
            do
            {
                Console.WriteLine("Looking for testUIAutomationForm . . . ");
                aeForm = aeDesktop.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.NameProperty, "testUIAutomationForm")); 
                ++numWaits; Thread.Sleep(100); } 
            while (aeForm == null && numWaits < 50);
            if (aeForm == null) throw new Exception("Failed to find testUIAutomationForm"); 
            else Console.WriteLine("Found it!");
        }

        private void databaseCreateButton_Click(object sender, EventArgs e)
        {

        }

    }
}
