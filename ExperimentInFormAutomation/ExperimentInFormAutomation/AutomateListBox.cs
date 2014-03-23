using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace ExperimentInFormAutomation
{
    class AutomateListBox
    {
        public void AutomateThisListBox(AutomationElement aeForm, int item )
        {
            AutomationElement aeListBox = aeForm.FindFirst(TreeScope.Children,
            new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.List));

            AutomationElementCollection aeListBoxItems = aeListBox.FindAll(TreeScope.Descendants, new PropertyCondition(AutomationElement.  .ControlTypeProperty, ControlType.ListItem));

            AutomationElement aeFirstItem =  aeListBoxItems[item];
            
            string s = (string)aeFirstItem.GetCurrentPropertyValue(AutomationElement.NameProperty);
        }
 
    }
}
