﻿using System;
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

        public static StringBuilder ConvertIputToNumbers(Array input)
        {
            StringBuilder  inputAsLetters = new StringBuilder();
            StringBuilder indexOfAlphabet = new StringBuilder();
            StringBuilder inputAsNumbers = new StringBuilder();
            String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            indexOfAlphabet.Append(alphabet);
            Array inputArray = input;

            foreach (String fives in inputArray)
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
                            inputAsNumbers.Append(n+1);
                            inputAsNumbers.Append(' ');
                        }
                    }
                }
            return inputAsNumbers;    
        }

     }
}
