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
            String input = inputField.Text;
            String noSpaces = RemoveSpaces.RemoveSpacesFromInput(input);
            string fives = CreateCipher.DivideByFive.MakeDivisibleByFive(input);
            List<String> convertedToFives = MakeGroupsOfFive.GroupsOfFive(fives);
            StringBuilder convertedToNumbers = ConvertLettersToNumbers.ConvertInputToNumbers(convertedToFives);
            CardDeck keyDeck = new CardDeck();


            encryptedField.Text = convertedToNumbers.ToString(); ;
        }
    }
}
