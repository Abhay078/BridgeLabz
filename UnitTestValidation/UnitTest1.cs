using UserRegistration1;


namespace UnitTestValidation
{
    [TestClass]
    public class UnitTest1
    {
        Validation v = new Validation();
        

        [TestMethod]
        public void NameTest()
        {
            
            bool b = v.ValidName("Abhay Srivastava");
            Assert.AreEqual(b, true);

        }
        [TestMethod]
        public void EmailTest()
        {
           // Validation v = new Validation();
            bool b = v.ValidEmail("Abhay@gmail.com");
            Assert.AreEqual(b, true);

        }
        [TestMethod]
        public void MobileTest()
        {
            //Validation v = new Validation();
            //bool b = v.ValidMobile("91 9044681905");
            bool c = v.ValidMobile("91 7881181888");
            Assert.AreEqual(c, true);
            

        }
        [TestMethod]
        public void PasswordTest()
        {
            //Validation v = new Validation();
            bool b = v.ValidPass("Abhay@345");
            Assert.AreEqual(b, true);

        }
        

    }
}