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


        public void AutomateThisListBox(AutomationElement aeForm, int item)
        {
         AutomationElement aeCombo = aeForm.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.ComboBox));
                
         ExpandCollapsePattern expandPattern = (ExpandCollapsePattern)aeCombo.GetCurrentPattern(ExpandCollapsePattern.Pattern);
         expandPattern.Expand();

         AutomationElementCollection aeListBoxItems = aeCombo.FindAll(TreeScope.Descendants, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.ListItem));
         AutomationElement itemToSelect = aeListBoxItems[item];
                    
         SelectionItemPattern selectPattern = (SelectionItemPattern)itemToSelect.GetCurrentPattern(SelectionItemPattern.Pattern);
         selectPattern.Select();

       }
    }
 
}


