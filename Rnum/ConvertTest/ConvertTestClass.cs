using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanNumeralConverter;

namespace ConvertTest
{
    public class ConvertTestClass
    {
               
        public void convertTest1()
        {
            Converter test1Convert = new Converter();
            test1Convert.roman = "I";
            test1Convert.CalculateValue();
            
            if (test1Convert.output == "1")
            {
                Console.WriteLine ("Test for I passed");
            }
            else
            {
                Console.WriteLine("Test for I failed");
            }
        }

        public void convertTest2()
        {
            Converter test2Convert = new Converter();
            test2Convert.roman = "IV";
            test2Convert.CalculateValue();

            if (test2Convert.output == "4")
            {
                Console.WriteLine("Test for IV passed");
            }
            else
            {
                Console.WriteLine("Test for IV failed");
            }
        }

        public void convertTest3()
        {
            Converter test3Convert = new Converter();
            test3Convert.roman = "IX";
            test3Convert.CalculateValue();

            if (test3Convert.output == "9")
            {
                Console.WriteLine("Test for IX passed");
            }
            else
            {
                Console.WriteLine("Test for IX failed");
            }
        }

        public void convertTest4()
        {
            Converter test4Convert = new Converter();
            test4Convert.roman = "X";
            test4Convert.CalculateValue();

            if (test4Convert.output == "10")
            {
                Console.WriteLine("Test for X passed");
            }
            else
            {
                Console.WriteLine("Test for X failed");
            }
        }

         public void convertTest5()
        {
            Converter test5Convert = new Converter();
            test5Convert.roman = "XC";
            test5Convert.CalculateValue();

            if (test5Convert.output == "90")
            {
                Console.WriteLine("Test for XC passed");
            }
            else
            {
                Console.WriteLine("Test for XC failed");
            }
        }

         public void convertTest6()
        {
            Converter test6Convert = new Converter();
            test6Convert.roman = "C";
            test6Convert.CalculateValue();

            if (test6Convert.output == "100")
            {
                Console.WriteLine("Test for C passed");
            }
            else
            {
                Console.WriteLine("Test for C failed");
            }
        }

         public void convertTest7()
         {
             Converter test7Convert = new Converter();
             test7Convert.roman = "CM";
             test7Convert.CalculateValue();

             if (test7Convert.output == "900")
             {
                 Console.WriteLine("Test for CM passed");
             }
             else
             {
                 Console.WriteLine("Test for CM failed");
             }
         }


         public void convertTest8()
         {
             Converter test8Convert = new Converter();
             test8Convert.roman = "M";
             test8Convert.CalculateValue();

             if (test8Convert.output == "1000")
             {
                 Console.WriteLine("Test for M passed");
             }
             else
             {
                 Console.WriteLine("Test for M failed");
             }
         }

         public void convertTest9()
         {
             Converter test9Convert = new Converter();
             test9Convert.roman = "MMM";
             test9Convert.CalculateValue();

             if (test9Convert.output == "3000")
             {
                 Console.WriteLine("Test for MMM passed");
             }
             else
             {
                 Console.WriteLine("Test for MMM failed");
             }
         }

        
    }
}
