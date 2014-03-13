﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.TreeItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;
using System.IO;
using System.Reflection;



namespace ExperimentInFormAutomation
{
    class AutomateCalendar
    {
        public void AutomateDatePicker(AutomationElement aeForm)
        {

            TestStack.White.Application app = TestStack.White.Application.Attach(??something To get the process id ArgumentOutOfRangeException the running ui??);

            //Failed attempt using the UI Automation framework
            //Window window = aeForm.GetWindow(SearchCriteria.ByText("testUIAutomationForm"), TestStack.White.Factory.InitializeOption.WithCache);
            //window.WaitWhileBusy();

          
            // AutomationElement aeCalendar = aeForm.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.AutomationIdProperty, "testDateTimePicker"));
            //aeCalendar.SetFocus();
            //ValuePattern getCalendarValue = (ValuePattern)aeCalendar.GetCurrentPattern(ValuePattern.Pattern);
            //getCalendarValue.SetValue("01/01/2013 09:32");
            //getCalendarValue.Current.Value = "01/01/2013";
        }
    }
}