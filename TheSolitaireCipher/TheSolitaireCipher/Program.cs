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

            String input = TakeInput.ReceiveInputToEncrypt();
            String noSpaces = RemoveSpaces.RemoveSpacesFromInput(input);
            string fives = DivideByFive.MakeDivisibleByFive(input);
            List<String> convertedToFives = MakeGroupsOfFive.GroupsOfFive(fives);
            StringBuilder convertedToNumbers = ConvertLettersToNumbers.ConvertIputToNumbers(convertedToFives);
            Console.WriteLine(convertedToNumbers);
            List<int> key = CreateTheDeck.CreateDeck();
            List<int> jokersMoved = MoveTheJokers.MoveJokers(key);
            Console.ReadKey();
        }
    }
}
