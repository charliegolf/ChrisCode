using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateCipher;
using System.Drawing;
using System.Windows.Forms;



namespace TheSolitaireCipher
{
    public class Program
    {
        static void Main()
        
        {
            Application.EnableVisualStyles();
            /*
           
            
            List<int> key = CardDeck.
            List<int> jokersMoved = MoveTheJokers.MoveJokers(key);
            List<int> cut = CutTheCards.TripleCut(jokersMoved);
            Console.ReadKey();
             */
            Application.Run(new MainForm());
        }
       
    }
}
