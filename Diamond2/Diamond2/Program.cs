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
                buildDiamond();
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

        public static void buildDiamond()
          {
            string alphabet = buildAlphabet();
            int rowLength = setStringLength();
            int goRight = rowLength;
            int goLeft = rowLength;
            int counterTop = 0;

               for (int i=0; i<=rowLength; i++)
              {
                   StringBuilder rowsTop = buildString();
                   rowsTop.Length=rowLength*2;
                   char thisChar = alphabet.ElementAt(counterTop);
                   if (i == 0)
                   {
                       rowsTop.Insert(goLeft, thisChar);
                   }
                   else
                   {
                       rowsTop.Insert(goLeft, thisChar);
                       rowsTop.Insert(goRight, thisChar);
                   }
                   counterTop++;
                   goLeft--;
                   goRight++;
                   Console.WriteLine(rowsTop);
               }

            int counterBottom = rowLength - 1;
            int goRight2 = 1;
            int goLeft2 = rowLength*2-2;

               for (int i = rowLength; i >0; i--)
              {
                  StringBuilder rowsBottom = buildString();
                  rowsBottom.Length = rowLength * 2;
                  char thisChar = alphabet.ElementAt(counterBottom);
                   if (i==1)
                   {
                       rowsBottom.Insert(goRight2, thisChar);
                   }
                   else 
                   {
                       rowsBottom.Insert(goLeft2, thisChar);
                       rowsBottom.Insert(goRight2, thisChar);
                   }
                  counterBottom--;
                  goLeft2--;
                  goRight2++;
                  Console.WriteLine(rowsBottom);
             }
            Console.ReadKey();
       }
    }
}
