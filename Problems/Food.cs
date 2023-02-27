using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class properties
    {
        public string name { get; set; }
        public double weight { get; set; }
        public double price_per_kg { get; set; }
        public double total_price { get; set; }
    }
    public class Food
    {
        public List<properties> rice { get; set; }
        public List<properties> wheat { get; set; }
        public List<properties> pulses { get; set; }


    }
}
