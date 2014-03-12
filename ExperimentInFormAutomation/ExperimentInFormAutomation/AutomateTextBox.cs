using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace ExperimentInFormAutomation
{
    class AutomateTextBox
    {
        public void AutomateThisTextBox(AutomationElement aeForm)
        {

            AutomationElement aeText = aeForm.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit));
            ValuePattern vpTextBox = (ValuePattern)aeText.GetCurrentPattern(ValuePattern.Pattern);
            vpTextBox.SetValue("Holy Cow, it worked!!");
            
        }
    }
}
