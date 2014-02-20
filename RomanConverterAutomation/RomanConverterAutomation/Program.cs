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


namespace RomanConverterAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of test cases
            string[] convertTestArray = new string[] { "I", "IV", "V", "IX", "X", "L", "XC", "C", "CM", "M", "MMM" };

            TestStack.White.Application app = TestStack.White.Application.Launch("C:\\rnum\\rnum.exe");
            Window window = app.GetWindow(SearchCriteria.ByText("ConvertForm"), TestStack.White.Factory.InitializeOption.WithCache);
            window.WaitWhileBusy();

           foreach (string value in convertTestArray)
            {
                string romanNumeral = value;
                Window main = app.GetWindow("ConvertForm");
                TextBox imput = main.Get<TextBox>(SearchCriteria.ByAutomationId("romanInput"));
                imput.BulkText = value;

                Button convert = main.Get<Button>(SearchCriteria.ByAutomationId("convertButton"));
                convert.Click();

                string arabicNumber;
                TextBox output = main.Get<TextBox>(SearchCriteria.ByAutomationId("arabicOutput"));
                output.ToString();

                arabicNumber = Convert.ToString(output.Text);

                //Send results to CSV 
                {
                    string filePath = "c:\\" + "RomanNumeralConversionResults.csv";
                    if (!File.Exists(filePath))
                    {
                        File.Create(filePath).Close();
                    }
                    string delimiter = ",";
                    string[][] result = new string[][]{
            new string[]{romanNumeral," converts to ",arabicNumber} /*add the values that you want inside a csv file. Mostly this function can be used in a 								foreach loop.*/
            };
                    int length = result.GetLength(0);
                    StringBuilder sb = new StringBuilder();
                    for (int index = 0; index < length; index++)
                        sb.AppendLine(string.Join(delimiter, result[index]));
                    File.AppendAllText(filePath, sb.ToString());
                    Thread.Sleep(2000);
                }
            }
        }
     }
}
