using System;

namespace UserRegistration1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Validation v = new Validation();
            bool b = true;
            while (b)
            {
                Console.WriteLine("Hello User!");
                Console.WriteLine("Press 1 for Validating Name\n Press 2 for Validating Email\n Press 3 for Validating Mobile\n Press 4 For validating Password" +
                    "\n Press 5 for Mood Analyser \n Press 6 for Exit");
                Console.WriteLine("Enter the choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        
                        Console.WriteLine("Enter the Full name");

                        string name = Console.ReadLine();
                        bool b1 = v.ValidName(name);
                        if (b1)
                        {
                            Console.WriteLine("Name is valid");
                        }
                        else
                        {
                            Console.WriteLine("Name is invalid");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the Email");

                        string Email = Console.ReadLine();
                        bool b2 = v.ValidEmail(Email);
                        if (b2)
                        {
                            Console.WriteLine("EMail is valid");
                        }
                        else
                        {
                            Console.WriteLine("Email is invalid");
                        }

                        break;
                        
                    case 3:
                        Console.WriteLine("Enter the Mobile");
                        string Mobile = Console.ReadLine();
                        bool b3 = v.ValidMobile(Mobile);
                        if (b3)
                        {
                            Console.WriteLine("Mobile is valid");
                        }
                        else
                        {
                            Console.WriteLine("Mobile is invalid");
                        }

                        break;
                    case 4:
                        Console.WriteLine("Enter the password");
                        string password= Console.ReadLine();
                        bool b4 = v.ValidPass(password);
                        if (b4)
                        {
                            Console.WriteLine("Password is valid");
                        }
                        else
                        {
                            Console.WriteLine("Password is invalid");
                        }
                        break;
                        case 5:
                        MoodAnalyser m = new MoodAnalyser();
                        Console.WriteLine("Enter the message");
                        string message = Console.ReadLine();
                        Console.WriteLine(m.MoodMessage(message));
                        
                        break;
                    case 6:
                        b = false;
                        break;
                }

            }

        }
    }
}