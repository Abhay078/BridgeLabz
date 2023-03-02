using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        public int totalNumberOfRides { get; set; }
        public double totalfare { get; set; }
        public double average { get; set; }
        public void CalculateAverage()
        {
            average = totalfare / totalNumberOfRides;

        }

    }
}
