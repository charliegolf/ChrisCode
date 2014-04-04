using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSolitaireCipher
{
    class FormatInput
    {
        public static string ReceiveInputToEncrypt()
        {
            Console.WriteLine("Please enter the text you wish to encrypt ");
            string inputText = Console.ReadLine().ToUpper();
            return inputText;
        }

        public static String RemoveSpacesFromInput()
        {
            string input = ReceiveInputToEncrypt();
            string spacelessInput = input.Replace(" ", "");
            return spacelessInput;
        }

        public static string MakeDivisibleByFive()
        {
            String remainder = RemoveSpacesFromInput();
            int remainderLength = remainder.Length % 5;
            StringBuilder pad = new StringBuilder();
            pad.Append(remainder);
            for (int i = 0; i < 5-remainder.Length; i++)
            {
                pad.Append("X");
            }

            String result  = pad.ToString();
            return result;
          }
        
        public static Array GroupsOfFive()
        {
            string input = MakeDivisibleByFive();
            int group= 5;
            int stringLength = input.Length;
            String[] fives= new String[stringLength];
            int counter = 0;
            for (int i = 0; i < stringLength; i += group)
            {
                if (i + group > stringLength) group = stringLength - i;
                fives[counter] = input.Substring(i, group);
                counter++;
            }
             return fives;
        }

     }
}
