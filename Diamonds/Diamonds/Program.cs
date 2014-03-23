using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamonds
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Alphabet = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            Console.Write("Please enter a lower case letter ");
            char input = Convert.ToChar(Console.ReadLine());
            int index = Array.IndexOf(Alphabet, input);
            StringBuilder line = new StringBuilder();

            for (int i = 0; i <= index; i++)
            {
                int lineLength = index+i;
                int topLeft = index*2+2-i;
                line.Length = lineLength;

                  for (int l = 0; l<=index; l++)
                  {
                  line.Append(' ');   
                  }

                      if (i==0)
                      {
                      string lineOne = " " + Alphabet[i];
                      Console.WriteLine(line.Append(lineOne));
                      }
                     else
                     {
                     line.Append(Alphabet[i]);
                     string upperLeftSide = line.ToString();
                     string upperMirror = upperLeftSide.Insert(topLeft, Convert.ToString((Alphabet[i])));
                     Console.WriteLine(upperMirror);
                     }
            }

          for (int i = index; i >=0; i--)
            {
                int lineLength = index + i;
                int bottomLeft = index * 2 + 2 - i;
                line.Length = lineLength;

                  for (int l = index; l >=0; l--)
                  {
                  line.Append(' ');
                  }
                  line.Append(Alphabet[i]);
                  string lowerLeftSide = line.ToString();

                    if (i != index && i != 0)
                    {
                    string lowerMirror = lowerLeftSide.Insert(bottomLeft, Convert.ToString((Alphabet[i])));
                    Console.WriteLine(lowerMirror);
                     }
                    if (i == 0)
                    {
                    string lastLine =  " "+line;
                    Console.WriteLine(lastLine);
                    }
            }
                    Console.ReadKey();
        }
    }
}
