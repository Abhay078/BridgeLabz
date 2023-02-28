using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration1
{
    public class MoodAnalyser
    {
        public string MoodMessage(string Message)
        {
            try
            {
                if (Message.Contains("Happy")||Message.Contains("happy"))
                {
                    return "Happy Mood";
                }
                else if (Message.Contains("Sad")||Message.Contains("sad"))
                {
                    return "Sad Mood";
                }
                else
                {
                    throw new MoodNotFoundException();

                }
                

            }
            catch(MoodNotFoundException e)
            {
                Console.WriteLine(e.Message);
                
                Console.WriteLine(e.GetType().Name);
                
                return "Happy Mood";

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return "Happy Mood";

            }
        }
    }
}
