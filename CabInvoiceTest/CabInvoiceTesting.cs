using System;
using CabInvoiceGenerator;
namespace CabInvoiceTest
{
    [TestClass]
    public class CabInvoiceTesting
    {
        CabInvoice cab = new CabInvoice(CabInvoice.Ridetype.NORMAL);
        CabInvoice cab1 = new CabInvoice(CabInvoice.Ridetype.PREMIUM);
        [TestMethod]
        public void GivenDistanceAndTime_returnFare()
        {
            double fare = cab.CalculateFare(1, 2);
            Assert.AreEqual(12.0, fare);

        }

        [TestMethod]
        public void GivenDistanceAndTime_returnFarePremium()
        {
            
            double fare = cab1.CalculateFare(1, 2);
            Assert.AreEqual(20.0, fare);

        }

        [TestMethod]
        public void GivenRides_returnTotalFare()
        {
            Ride[] rides = { new Ride(7.0, 3.0), new Ride(2.0, 1.0) };
            double result = cab.MultipleRide(rides);
            double expected = 94.0D;

            Assert.AreEqual(result, expected);

        }
        [TestMethod]
        public void GivenInvoice_returnTotalRidesTotalFare()
        {
            Ride[] rides = { new Ride(7.0, 3), new Ride(6.5, 4) };
            InvoiceSummary summary = new InvoiceSummary();
            InvoiceSummary result = cab.CalculateInvoice(rides);
            summary.totalfare = 142D;
            summary.totalNumberOfRides = 2;
            summary.CalculateAverage();
            if (result.totalfare == summary.totalfare && result.totalNumberOfRides == summary.totalNumberOfRides && result.average == summary.average)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
        [TestMethod]
        public void GivenUserId_ReturnInvoice()
        {
            Ride[] ride = { new Ride(2.0, 2.0), new Ride(3.0, 2.0) };
            string userId = "123";

            RideRepository repository = new RideRepository();
            repository.AddRepo(userId, ride);
            Ride[] actual = repository.GetRide(userId);

            InvoiceSummary invoiceSummary = new InvoiceSummary();
            InvoiceSummary result = cab.RepoFetch(userId);
            invoiceSummary.totalfare = 54D;
            invoiceSummary.totalNumberOfRides = 2;
            invoiceSummary.CalculateAverage();
            if (result.totalfare == invoiceSummary.totalfare && result.totalNumberOfRides == invoiceSummary.totalNumberOfRides && result.average == invoiceSummary.average)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }


        }
    }
}