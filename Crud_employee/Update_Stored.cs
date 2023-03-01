using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Crud_employee
{
    internal class Update_Stored
    {
        public Update_Stored() {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
                SqlConnection con= new SqlConnection(cs);
                Console.WriteLine("Enter the value of id you want to update");
                int  id=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of salary you want to update");
                long salary=Convert.ToInt64(Console.ReadLine());
                
                SqlDataAdapter sd = new SqlDataAdapter();
                sd.SelectCommand = new SqlCommand("sp_updateEmployee", con);
                sd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sd.SelectCommand.Parameters.AddWithValue("@salary", salary);
                sd.SelectCommand.Parameters.AddWithValue("@id", id);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                




            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
;