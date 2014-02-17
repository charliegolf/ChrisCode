using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvertTest;




namespace ConversionTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Do you want to run the tests? Y/N ");
            string response = Console.ReadLine();
            if (response == "Y" || response == "y")
            {
                ConvertTestClass thisTest = new ConvertTestClass();
                thisTest.convertTest1();
                thisTest.convertTest2();
                thisTest.convertTest3();
                thisTest.convertTest4();
                thisTest.convertTest5();
                thisTest.convertTest6();
                thisTest.convertTest7();
                thisTest.convertTest8();
                thisTest.convertTest9();
                Console.ReadKey();
            }
            
                
        }
    }
}
