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


   
    }
}
