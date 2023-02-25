using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Crud_employee
{
    internal class Update
    {
        public Update() {
            string cs = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(cs);
                string query = "UPDATE Employee SET name=@name, Salary=@Salary WHERE id=@id;";
                SqlCommand cmd = new SqlCommand();
                Console.WriteLine("Enter the id that you want to update");
                string id=Console.ReadLine();
                Console.WriteLine("Enter the name that you want to update");
                string name=Console.ReadLine();
                Console.WriteLine("Enter the salary that you want to update");
                string salary=Console.ReadLine();
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.CommandText = query;
                cmd.Connection= con;
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    Console.WriteLine("data is successfully updated");
                }
                else
                {
                    Console.Write("Failed to update data");
                }


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
