using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_employee
{
    internal class Create_Stored_procedure
    {
        public Create_Stored_procedure()
        {
            string cs = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            try
            {

                string query = "CREATE PROCEDURE sp_selectEmployee @salary bigint AS SELECT * FROM Employee WHERE Salary=@salary;  ";

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Your table is created");



            }
            catch (Exception ex)
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
