using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Problems.JsonInventory;

namespace Problems
{
    public class JsonInventory
    {
        public void ReadJson(string path)
        {
            string json=File.ReadAllText(path);
            dynamic res=Newtonsoft.Json.JsonConvert.DeserializeObject<Food>(json);
            double trice = 0;
            double twheat = 0;
            double tpulse = 0;
            Food obj=new Food();
            foreach(var items in res.rice)
            {
                trice = items.price_per_kg * items.weight;
                List<properties> lis=new List<properties>();
                lis.Add(new properties
                {
                    name=items.name,
                    price_per_kg=items.price_per_kg,
                    weight=items.weight,
                    total_price=trice

                });
                obj.rice = lis;
                foreach (var item in lis) {
                    Console.WriteLine(item.name);
                }
            }

            foreach (var items in res.wheat)
            {
                twheat = items.price_per_kg * items.weight;
                List<properties> lis = new List<properties>();
                lis.Add(new properties
                {
                    name = items.name,
                    price_per_kg = items.price_per_kg,
                    weight = items.weight,
                    total_price = twheat

                });
                obj.wheat = lis;
                
            }
            foreach (var items in res.pulses)
            {
                tpulse = items.price_per_kg * items.weight;
                List<properties> lis = new List<properties>();
                lis.Add(new properties
                {
                    name = items.name,
                    price_per_kg = items.price_per_kg,
                    weight = items.weight,
                    total_price = tpulse

                });
                obj.pulses = lis;
                
            }
            string jsonstring = JsonConvert.SerializeObject(obj);
            string newfile = "D:\\BridgeLabz_Problems\\Problems\\FoodUpdated.json";
            File.WriteAllText(newfile, jsonstring);
        }

    }
    


        
    
}
