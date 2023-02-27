using NLog;
using System;
namespace NlogImplement
{
    class Program
    {
        public static void Main(string [] args)
        {
            
            try
            {
                var logger=LogManager.GetCurrentClassLogger();
                Console.WriteLine("Enter the reason of Entering in Library");
                string s=Console.ReadLine();
                Console.WriteLine("Enter the College Id Number");
                int id=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Student Name");
                string name= Console.ReadLine();

               
                logger.Info($" The reason :- {s} and the student id is:- {id} and name is:- {name}" );

            }
           catch(Exception ex)
            {
                
                var logger = NLog.LogManager.GetCurrentClassLogger();
                logger.ErrorException("Ohh Error", ex);

            }
            finally
            {
                NLog.LogManager.Shutdown();

            }
            

        }
    }
}
