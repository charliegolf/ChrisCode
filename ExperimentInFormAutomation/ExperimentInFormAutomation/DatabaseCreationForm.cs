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
            ILaunchApplications thisLAunch = new StartAutomationTestForm();
            thisLAunch.LaunchTestUINavigation();

            FindApplication thisFind = new FindApplication();
            AutomateTextBox thisTextBox = new AutomateTextBox();
            thisTextBox.AutomateThisTextBox(thisFind.FindForm());
        
         }  
    }
}
