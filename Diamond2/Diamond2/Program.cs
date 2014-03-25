using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond2
{
    class Program
    {
        static void Main(string[] args)
             {
                StringBuilder line = buildString();
                buildDiamond(line);
             }

        public static string buildAlphabet()
            {
               string alphabet = "abcdefghijklmnopqrstuvwxyz";
               return alphabet;
            }

        public static char getInput()
           {
              Console.Write("Please enter a lower case letter ");
              char letter = Convert.ToChar(Console.ReadLine());
              return letter;
           }


        public static StringBuilder buildString()
           {
             StringBuilder line = new StringBuilder();
             return line;
           }

        public static int setStringLength()
          {
            string alphabet = buildAlphabet();
            char character = getInput();
            int length = alphabet.IndexOf(character);
            return length;
          }

        public static void buildDiamond(StringBuilder line)
          {
            string alphabet = buildAlphabet();
            int rowLength = setStringLength();
            int goRight = rowLength;
            int goLeft = rowLength;
            int counter = 0;

               for (int i=0; i<=rowLength; i++)
              {
                   StringBuilder rows = buildString();
                   rows.Length=rowLength*2;
                   char thisChar = alphabet.ElementAt(counter);
                   if (i == 0)
                   {
                       rows.Insert(goLeft, thisChar);
                   }
                   else
                   {
                       rows.Insert(goLeft, thisChar);
                       rows.Insert(goRight, thisChar);
                   }
                   counter++;
                   goLeft--;
                   goRight++;
                   Console.WriteLine(rows);
               }

            int counter2 = rowLength - 1;
            int goRight2 = 1;
            int goLeft2 = rowLength*2-2;

               for (int i = rowLength; i >0; i--)
              {
                  StringBuilder rows2 = buildString();
                  rows2.Length = rowLength * 2;
                  char thisChar = alphabet.ElementAt(counter2);
                   if (i==1)
                   {
                       rows2.Insert(goRight2, thisChar);
                   }
                   else 
                   {
                       rows2.Insert(goLeft2, thisChar);
                       rows2.Insert(goRight2, thisChar);
                   }
                  counter2--;
                  goLeft2--;
                  goRight2++;
                  Console.WriteLine(rows2);
             }
            Console.ReadKey();
       }
    }
}
