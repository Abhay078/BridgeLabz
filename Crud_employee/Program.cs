using Crud_employee;
using System;
using System.Diagnostics;

namespace Crud_employee
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            while (b)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Hello user , Welcome !" +
                    "\n Press 1 for Inserting data in table of Database\n Press 2 for Display the data from Database\n Press 3 for Updating Details" +
                    "\n Press 4 for Creating table in database \n Press 5 for Creating stored Procedure \n" +
                    " Press 6 for Select Stored Procedure\n Press 7 for Updating data through stored procedure");


                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Insert insert = new Insert();
                        break;
                    case 2:
                        Select select= new Select();
                        break;
                    case 3:
                       Update update= new Update();
                        break;
                    case 4:
                        Create create= new Create();
                        break;
                    case 5:
                        Create_Stored_procedure csp= new Create_Stored_procedure();
                        break;
                    case 6:
                        select_stored_procedure s1=new select_stored_procedure();
                        break;
                    case 7:
                        Update_Stored us=new Update_Stored();
                        break;
                    case 8:
                        b = false;
                        break;
                    

                }
            }
        }
    }
}

