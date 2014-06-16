using CreateCipher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreateCypher;



namespace TheSolitaireCipher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String input = inputField.Text.ToUpper();
            String noSpaces = RemoveSpaces.RemoveSpacesFromInput(input);
            string fives = CreateCipher.DivideByFive.MakeDivisibleByFive(input);
            List<String> convertedToFives = MakeGroupsOfFive.GroupsOfFive(fives);
            StringBuilder convertedToNumbers = ConvertLettersToNumbers.ConvertInputToNumbers(convertedToFives);
            StringBuilder keyStream = new StringBuilder();
            CardDeck keyDeck = new CardDeck();
            int JokerAIndex = 52;
            int JokerBIndex = 53;
            for (int countLetter = 0; countLetter <= convertedToNumbers.Length; countLetter++)
            {
                keyDeck.MoveCard(JokerAIndex,1);
                JokerAIndex = JokerAIndex + 1;
                keyDeck.MoveCard(JokerBIndex,2);
                JokerBIndex = JokerBIndex + 2;
                keyDeck.Shuffle();
                keyDeck.Cut();
                keyStream.Append((keyDeck.FindOutputLetter()));
            }
            
            //encryptedField.Text = convertedToNumbers.ToString();
            encryptedField.Text = keyStream.ToString();
        }
    }
}
