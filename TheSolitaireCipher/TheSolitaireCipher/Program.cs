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
            String spacesRemoved = RemoveSpaces.RemoveSpacesFromInput(input);
            String divisibleByFive = DivideByFive.MakeDivisibleByFive(spacesRemoved);
            List<String> groupedByFive = MakeGroupsOfFive.GroupsOfFive(divisibleByFive);
            StringBuilder lettersToNumbers = ConvertLettersToNumbers.ConvertIputToNumbers(groupedByFive);
            List<int> deck = CreateTheDeck.CreateDeck();
            List<int> jokersMoved = MoveTheJokers.MoveJokers(deck);
            Console.ReadKey();
        }
    }
}
