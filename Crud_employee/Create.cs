using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_employee
{
    internal class Create
    {
        public Create() {
            string cs= ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            try
            {

                string query = "CREATE TABLE Project_tbl ( id INT IDENTITY PRIMARY KEY,Proj_name varchar(50),emp_name varchar(50))  ";

                con.Open();
                SqlCommand cmd=new SqlCommand(query, con);
                 cmd.ExecuteNonQuery();
                Console.WriteLine("Your table is created");
                


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {

            }
        }
    }
}
