using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.TreeItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;
using System.IO;
using System.Reflection;
using RomanConverterAutomation;


namespace RomanConverterAutomationLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
           RomanConverterAutomation.ConverionsAutomation thisAutomation =  new RomanConverterAutomation.ConverionsAutomation();
           thisAutomation.Automation();
        }
    }
}
