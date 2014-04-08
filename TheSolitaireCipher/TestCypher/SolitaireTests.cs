using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreateCipher;


namespace TestCipher
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

            String input = FormatInput.ReceiveInputToEncrypt(); 
            String fives = FormatInput.RemoveSpacesFromInput(input);  
                 Assert.IsTrue(input.Length % 5 ==0);
        }
        
        [TestMethod]
        public void IndexOfAIsOne()
        {
             string A = "A";
             List<String> aList = FormatInput.GroupsOfFive(A);
             StringBuilder indexA = FormatInput.ConvertIputToNumbers(aList);
             Assert.IsTrue(indexA[0] == 1);
        }

        [TestMethod]
        public void IndexOfJIsTen()
        {
             string J = "J"; 
             List<String> jList = FormatInput.GroupsOfFive(J);
             StringBuilder indexA = FormatInput.ConvertIputToNumbers(jList);
             Assert.IsTrue(indexA[0] == 10);

         }

         [TestMethod]
         public void IndexOfXIsTwentyFour()
         {
              string Z = "Z";
              List<String> zList = FormatInput.GroupsOfFive(Z);
              StringBuilder indexA = FormatInput.ConvertIputToNumbers(zList);
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
