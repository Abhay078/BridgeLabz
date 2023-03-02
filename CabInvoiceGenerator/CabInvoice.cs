using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    
    public class CabInvoice
    {
        public enum Ridetype {
            NORMAL,PREMIUM
            
        };

        Ridetype ridetype;
        public double minimumCost;
        public double distance;
        public double time;
        public double totalMultipleSum = 0D;
        public int costPerKm;
        public int costPerMin;

        public Dictionary<int, Ride> pairs = new Dictionary<int, Ride>();
        public CabInvoice(Ridetype ridetype)
        {
            this.ridetype= ridetype;
            if (ridetype.Equals(Ridetype.PREMIUM))
            {
                this.costPerMin = 2;
                this.costPerKm=15;
                this.minimumCost = 20;
            }
            else
            {
                this.costPerMin = 1;
                this.costPerKm=10;
                this.minimumCost = 5;
            }

        }

        public double CalculateFare(double distance, double time)
        {
            double totalFare = 0D;
            totalFare = distance * costPerKm + time * costPerMin;
            if (totalFare < minimumCost)
            {
                return minimumCost;
            }
            else
            {
                return totalFare;
            }
        }

            public double MultipleRide(Ride[] rides)
        {
            double TotalFare = 0D;
            foreach(var data in rides)
            {
                TotalFare += CalculateFare(data.distance, data.time);

            }
            return TotalFare;
        }


       


        
        public InvoiceSummary CalculateInvoice(Ride[] rides)
        {
            double totalFare = this.MultipleRide(rides);
            InvoiceSummary invoiceSummary = new InvoiceSummary();
            invoiceSummary.totalfare = totalFare;
            invoiceSummary.totalNumberOfRides = rides.Count();
            invoiceSummary.CalculateAverage();
            return invoiceSummary;
        }

        public InvoiceSummary RepoFetch(string userid)
        {
            Ride[] ride = { new Ride(2.0, 2.0), new Ride(3.0, 2.0) };
            RideRepository repository = new RideRepository();
            repository.AddRepo(userid, ride);
            InvoiceSummary invoiceSummary = new InvoiceSummary();
            InvoiceSummary result = CalculateInvoice(ride);
            return result;
        }
    }
}
