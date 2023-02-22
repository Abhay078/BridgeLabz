using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Problems
{
    internal class CustomizeMessage
    {
        public CustomizeMessage() {
            string message = " Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx.Please,let us know in case of any clarification Thank you BridgeLabz 01/01/2016.";
            string pattern1 = "<<name>>";
            string pattern2 = "<<full name>>";
            string pattern3 = "91-[x]{10}";
            string pattern4 = @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))";
            Console.WriteLine("Enter your first name");
            string replacefirst=Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string replacelast = Console.ReadLine();
            Console.WriteLine("Enter your contact number");
            string contact = Console.ReadLine();
            string result1=Regex.Replace(message, pattern1, replacefirst);
            string result2 = Regex.Replace(result1, pattern2, replacefirst +" "+ replacelast);
            string result3 = Regex.Replace(result2, pattern3, contact);
            string result4=Regex.Replace(result3, pattern4, DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine("Message after Modification is :-");
            Console.WriteLine(result4);
            Console.ReadLine();


            

            


        }
    }
}
