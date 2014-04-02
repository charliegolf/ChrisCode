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
/*
        [TestMethod]
        public void IsAGroupOf5()
        {
            Assert.IsTrue(groupLength == 5);
        }

        [TestMethod]
        public void IndexOfAIsOne()
        {

        }

        [TestMethod]
        public void IndexOfJIsTen()
        {
        }

        [TestMethod]
        public void IndexOfJIsTen()
        {
        }

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
