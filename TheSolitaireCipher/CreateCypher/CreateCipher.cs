using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace CreateCipher
{
    public class TakeInput
    {
        public static string ReceiveInputToEncrypt()
        {
            Console.WriteLine("Please enter the text you wish to encrypt ");
            string inputText = Console.ReadLine().ToUpper();
            return inputText;
        }
    }

    public class RemoveSpaces
    {

        public static String RemoveSpacesFromInput(string input)
        {
            string spacelessInput = input.Replace(" ", "");
            return spacelessInput;
        }
    }

    public class DivideByFive
    {

        public static String MakeDivisibleByFive(string remainder)
        {
            int remainderLength = remainder.Length % 5;
            StringBuilder pad = new StringBuilder();
            pad.Append(remainder);            if (remainderLength != 0)
            { 
              for (int i = 0; i < 5-remainderLength; i++)
                {
                    pad.Append("X");
                }
            }

            String result  = pad.ToString();
            return result;
          }
     }
     
    public class MakeGroupsOfFive
    {
        
        public static List<String> GroupsOfFive(string input)
        {
            int group= 5;
            int stringLength = input.Length;
            List<String> fives= new List<String>();
            int counter = 0;
            for (int i = 0; i < stringLength; i += group)
            {
                if (i + group > stringLength) group = stringLength - i;
                fives.Add(input.Substring(i, group));
                counter++;
            }
             return fives;
        }
    }

    public class ConvertLettersToNumbers
    {

        public static StringBuilder ConvertIputToNumbers(List<string> input)
        {
            StringBuilder inputAsLetters = new StringBuilder();
            StringBuilder indexOfAlphabet = new StringBuilder();
            StringBuilder inputAsNumbers = new StringBuilder();
            String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            indexOfAlphabet.Append(alphabet);
            List<String> inputList = new List<String>();
            inputList = input;

            foreach (String fives in inputList)
            {
                inputAsLetters.Append(fives);
            }

            for (int i = 0; i < inputAsLetters.Length; i++)
            {
                char c = inputAsLetters[i];
                for (int n = 0; n < indexOfAlphabet.Length; n++)
                {
                    char letter = indexOfAlphabet[n];
                    if (c == letter)
                    {
                        inputAsNumbers.Append(n + 1);
                        inputAsNumbers.Append(' ');
                    }
                }
            }
            return inputAsNumbers;
        }
    }
  }
  
