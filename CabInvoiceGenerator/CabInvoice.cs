using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class CabInvoice
    {
        public double totalMultipleSum = 0D;
        public double MultipleRides(int rides,double distance,double time){
            for(int i = 1; i <= rides; i++)
            {

                totalMultipleSum += distance * 10 + time * 1;


            }
            return totalMultipleSum;
            

        }
        public double CalculateFare(double distance,double time)
        {
            double totalFare = 0D;
            totalFare = distance * 10 + time * 1;
            if (totalFare < 5)
            {
                return 5.0;
            }
            else
            {
                return totalFare;
            }


        }
    }
}
