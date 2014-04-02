using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSolitaireCipher
{
    public class Program
    {
        static void Main(string[] args)
        {
            string spacelessInput = FormatInput.RemoveSpacesFromInput();
           
            Console.WriteLine(spacelessInput);
            Console.ReadLine();
 
          

        }
    }
}
