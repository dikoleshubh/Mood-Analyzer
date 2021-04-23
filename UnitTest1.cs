using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sad_Mood()
        {  //   //Arrange;
            MoodAnalyser mood = new MoodAnalyser("I am in sad mood");
            string expected = "sad";

            ////Act
            string actual = mood.Analyser();

            //Asert
            Assert.AreEqual(expected, actual);
        }
    }
}
