using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rnum;



namespace RomanNumeralConverter
{
    public class Converter
    {
           
            
            static string roman =  rNumForm.romanValue;
            static string output = rNumForm.arabicValue;
            static char[] romanArray = roman.ToCharArray();
            static  int count = 0;
            static string lastNumber = "";

            static string CalculateValue()
            {

            for (int i = 0; i < romanArray.Length; i++)
            {
                
                string number = Convert.ToString(romanArray[i]);
                if (number == "I")
                {
                    count += 1;
                    lastNumber = number;
                }

                if (number == "V" && lastNumber == "I")
                {
                    count += 5-2;
                }

                if (number == "V" && lastNumber != "I")
                {
                    count += 5;
                }
                if (number == "X" && lastNumber == "I")
                {
                    count += 10 - 2;
                }

                if (number == "X" && lastNumber != "I")
                {
                    count += 10;
                    lastNumber = number;
                }
                if (number == "L" && lastNumber == "X")
                {
                    count += 50 - 20;
                }

                if (number == "L" && lastNumber != "X")
                {
                    count += 50;
                }
                if (number == "C" && lastNumber == "X")
                {
                    count += 100 - 20;
                }

                if (number == "C" && lastNumber != "X")
                {
                    count += 100;
                    lastNumber = number;

                }
                if (number == "D" && lastNumber == "C")
                {
                    count += 500 - 200;
                }

                if (number == "D" && lastNumber != "C")
                {
                    count += 500;
                }
                if (number == "M" && lastNumber == "C")
                {
                    count += 1000 - 200;
                }

                if (number == "M" && lastNumber != "C")
                {
                    count += 1000;
                    lastNumber = number;
                }


                 output = Convert.ToString(count);
                 return output;
            }
                

            }
    }
}
