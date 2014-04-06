using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TheSolitaireCipher
{
    [TestClass]
    public class SolitaireTests
    {
        [TestMethod]
        public void IsUpperCase()
        {
            string result = FormatInput.ReceiveInputToEncrypt();
            Assert.AreEqual(result.ToUpper(), result);
        }

        [TestMethod]
        public void IsDivisibleBy5()
        {
                 String input = FormatInput.RemoveSpacesFromInput();  
                 Assert.IsTrue(input.Length % 5 ==0);
        }
        
                [TestMethod]
                public void IndexOfAIsOne()
                {
                    string[] A = new string[1] {"A"};
                    StringBuilder indexA = FormatInput.ConvertIputToNumbers(A);
                    Assert.IsTrue(indexA[0] == 1);
                 }

                [TestMethod]
                public void IndexOfJIsTen()
                {
                    string[] A = new string[1] { "J" };
                    StringBuilder indexA = FormatInput.ConvertIputToNumbers(A);
                    Assert.IsTrue(indexA[0] == 10);

                }

                [TestMethod]
                public void IndexOfXIsTwentyFour()
                {
                    string[] A = new string[1] { "Z" };
                    StringBuilder indexA = FormatInput.ConvertIputToNumbers(A);
                    Assert.IsTrue(indexA[0] == 26);
                }
        /*
                [TestMethod]
                public void IndexOfFirstInputIsOne()
                {
                }

                [TestMethod]
                public void IndexOfFithInputIsFive()
                {
                }

                [TestMethod]
                public void IsToalGreaterThanTwentySix()
                {
                }

                [TestMethod]
                public void FirstNumberInputIsA()
                {
                }

                [TestMethod]
                public void FithNumberIsE()
                {
                }
          */
    }
}
