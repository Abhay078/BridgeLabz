using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        Dictionary<string, List<Ride>> pairs = null;
        public RideRepository() { 
            this.pairs= new Dictionary<string, List<Ride>>();
        }
        
        public void AddRepo(string userid,Ride[] ride)
        {
            bool ridelist=this.pairs.ContainsKey(userid);
            if(!ridelist)
            {
                List<Ride> list = new List<Ride>();
                list.AddRange(ride);
                this.pairs.Add(userid, list);

            }
            


        }
        public Ride[] GetRide(string userId)
        {
            return this.pairs[userId].ToArray();
        }
    }
}
