using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Crud_employee
{
    internal class Insert
    {
        public Insert() {
            string cs = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            SqlConnection con = null;
            try
            {
                 con = new SqlConnection(cs);
                
                SqlCommand cmd = new SqlCommand();
                string query = "INSERT INTO Employee VALUES(@name,@City,@Mobile,@Salary);";
                Console.WriteLine("enter the name of employee");
                string name = Console.ReadLine();
                Console.WriteLine("enter the city of employee");
                string City = Console.ReadLine();
                Console.WriteLine("enter the Mobile number of employee");
                string Mobile = Console.ReadLine();
                Console.WriteLine("enter the salary of employee");
                string Salary = Console.ReadLine();
                con.Open();
                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@City", City);
                cmd.Parameters.AddWithValue("@Mobile", Mobile);
                cmd.Parameters.AddWithValue("@Salary", Salary);
                cmd.CommandText= query;
                cmd.Connection= con;
                int a=cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    Console.WriteLine("data is successfully inserted");
                }
                else
                {
                    Console.Write("Failed to insert data");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            

        }
    }
}
