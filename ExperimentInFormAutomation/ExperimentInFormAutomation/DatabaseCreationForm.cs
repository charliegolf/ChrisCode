﻿using System;
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

            FindProcessID ProcessID = new FindProcessID();
            int pID = ProcessID.FindFormProcessID(p);
            FindApplication Find = new FindApplication();
            AutomationElement FindForm = Find.FindForm();
            AutomateTextBox thisTextBox = new AutomateTextBox();
            thisTextBox.AutomateThisTextBox(FindForm);

            AutomateCalendar thisCalendar = new AutomateCalendar();
            thisCalendar.AutomateDatePicker(FindForm, pID);
        
         }  
    }
}
