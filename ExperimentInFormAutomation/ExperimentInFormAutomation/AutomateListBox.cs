using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Automation.Peers;

namespace ExperimentInFormAutomation
{
    class AutomateListBox
    {
       // public void AutomateThisListBox(AutomationElement aeForm, int item )
        //{
            /*
            AutomationElement aeListBox = aeForm.FindFirst(TreeScope.Children,
            new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.ComboBox));

            AutomationElementCollection aeListBoxItems = aeListBox.FindAll(TreeScope.Descendants, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.ListItem));

            AutomationElement aeFirstItem =  aeListBoxItems[3];
            
            string s = (string)aeFirstItem.GetCurrentPropertyValue(AutomationElement.NameProperty);

          */

        public void AutomateThisListBox(AutomationElement aeForm, int item)
        {
        if(aeForm == null)
        throw new Exception("Combo Box not found");

        //Get the all the list items in the ComboBox
        AutomationElementCollection comboboxItem = aeForm.FindAll(TreeScope.Children, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.ListItem));

        //Expand the combobox

        ComboBoxAutomationPeer peer =
         new ComboBoxAutomationPeer(aeComboBox);
        IExpandCollapseProvider provider =
          (IExpandCollapseProvider)
          peer.GetPattern(PatternInterface.ExpandCollapse);
        provider.Expand();
       // ExpandCollapsePattern expandPattern = (ExpandCollapsePattern)aeForm.GetCurrentPattern(ExpandCollapsePattern.Pattern);
       // expandPattern.Expand();

        //Index to set in combo box
        AutomationElement itemToSelect = comboboxItem[item];

        //Finding the pattern which need to select
        SelectionItemPattern selectPattern = (SelectionItemPattern)itemToSelect.GetCurrentPattern(SelectionItemPattern.Pattern);
        selectPattern.Select();
       }
    }
 
}


