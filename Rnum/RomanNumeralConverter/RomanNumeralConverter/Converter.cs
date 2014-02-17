using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RomanNumeralConverter
{
    public class Converter
    {
            public string roman {get; set;}
            public string output {get; set;}
            public  int count;
            public string lastNumber;

            public string CalculateValue()
            {
             char[] romanArray = roman.ToCharArray();

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
                
            }
            return output;  

            }
    }
}
