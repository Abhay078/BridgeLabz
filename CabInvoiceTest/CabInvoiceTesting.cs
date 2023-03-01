using System;
using CabInvoiceGenerator;
namespace CabInvoiceTest
{
    [TestClass]
    public class CabInvoiceTesting
    {
        CabInvoice cab=new CabInvoice();
        [TestMethod]
        public void GivenDistance_returnFare() 
        {
            double fare=cab.CalculateFare(1, 2);
            Assert.AreEqual(12.0, fare);

        }
        [TestMethod]
        public void GivenNothing_returnFare()
        {
            double fare = cab.CalculateFare(0, 0);
            Assert.AreEqual(5.0, fare);

        }
        [TestMethod]
        public void GivenRides_returnTotalFare()
        {
            double fare = cab.MultipleRides(2,1,2);
            
            Assert.AreEqual(24.0, fare);

        }
    }
}