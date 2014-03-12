using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace ExperimentInFormAutomation
{
    class AutomateCalendar
    {
        public void AutomateDatePicker(AutomationElement aeForm)
        {
            AutomationElement aeCalendar = aeForm.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.AutomationIdProperty, "testDateTimePicker"));
            aeCalendar.SetFocus();
            ValuePattern getCalendarValue = (ValuePattern)aeCalendar.GetCurrentPattern(ValuePattern.Pattern);
            //getCalendarValue.SetValue("01/01/2013 09:32");
            //getCalendarValue.Current.Value = "01/01/2013";
        }
    }
}
