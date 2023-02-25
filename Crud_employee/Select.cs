using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Crud_employee
{
    internal class Select
    {
        public Select()
        {
            string cs = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            SqlConnection con = null;
            try
            {

                con = new SqlConnection(cs);
                string query = "SELECT * FROM Employee;";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr=cmd.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine("ID= " + dr["id"] + " Name " + dr["name"] + " City " + dr["City"]+" Mobile " + dr["Mobile"]+" Salary " + dr["Salary"] );
                }

            }
            catch (Exception ex)
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
