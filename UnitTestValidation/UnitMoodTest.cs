using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistration1;

namespace UnitTestValidation
{
    [TestClass]
    public class UnitMoodTest
    {
        MoodAnalyser m=new MoodAnalyser();
        [TestMethod]
        public void GivenHappyString_returnHappyMood()
        {

            string s = m.MoodMessage("I am happy Today");

            Assert.AreEqual("Happy Mood", s);
        }

        [TestMethod]
        public void MoodTest1()
        {

            string s = m.MoodMessage("I am sad Today");

            Assert.AreEqual("Sad Mood", s);
        }
        [TestMethod]
        public void MoodTest2()
        {

            string s = m.MoodMessage("I am good Today");

            Assert.AreEqual("Happy Mood", s);
        }
        [TestMethod]
        public void MoodTest3()
        {

            string s = m.MoodMessage("");

            Assert.AreEqual("Happy Mood", s);
        }
    }
}
