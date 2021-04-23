using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Happy_Mood()
        {  //   //Arrange;
            MoodAnalyser mood = new MoodAnalyser("I am in happy mood");
            string expected = "happy";

            ////Act
            string actual = mood.Analyser();

            //Asert
            Assert.AreEqual(expected, actual);
        }
    }
}
