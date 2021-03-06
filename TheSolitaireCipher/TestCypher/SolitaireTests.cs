﻿using System;
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
        public void IsDivisibleBy5()
        {
            String input = "iohferiohfnnjFWEF fefweuihdqwiohjce gfgGREG"; 
            String spaceless = RemoveSpaces.RemoveSpacesFromInput(input); 
            String fives =  DivideByFive.MakeDivisibleByFive(spaceless);
            Assert.IsTrue(fives.Length % 5 == 0);
        }
        
        [TestMethod]
        public void IndexOfAIsOne()
        {
             string A = "Adkfjt"; ;
             List<String> aList = MakeGroupsOfFive.GroupsOfFive(A);
             List <int> indexA = ConvertLettersToNumbers.ConvertInputToNumbers(aList);
             Assert.AreEqual(1, indexA[0]);
        }

        [TestMethod]
        public void IndexOfJIsTen()
        {
             string J = "J";
             List<String> jList = MakeGroupsOfFive.GroupsOfFive(J);
             List <int> indexA = ConvertLettersToNumbers.ConvertInputToNumbers(jList);
             Assert.AreEqual(24, indexA[1]);

         }

         [TestMethod]
         public void IndexOfXIsTwentyFour()
         {
              string Z = "Z";
              List<String> zList = MakeGroupsOfFive.GroupsOfFive(Z);
              List <int> indexA = ConvertLettersToNumbers.ConvertInputToNumbers(zList); string indexAString = indexA.ToString();
              Int16 atIndex0 = Convert.ToInt16(indexAString);
              Assert.IsTrue(atIndex0 == 26);
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
