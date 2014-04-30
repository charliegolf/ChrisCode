using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateCipher;

namespace TheSolitaireCipher
{
    public class Program
    {
        static void Main(string[] args)
        {
            String input = FormatInput.ReceiveInputToEncrypt();
            String noSpaces = FormatInput.RemoveSpacesFromInput(input);
            string fives = FormatInput.MakeDivisibleByFive(input);
            List<String> convertedToFives = FormatInput.GroupsOfFive(fives);
            StringBuilder convertedToNumbers = FormatInput.ConvertIputToNumbers(convertedToFives);
            Console.WriteLine(convertedToNumbers);
            List<int> key = KeyTheDeck.CreateDeck();
            List<int> jokersMoved = KeyTheDeck.MoveJokers(key);

            Console.ReadKey();
        }
    }
}
