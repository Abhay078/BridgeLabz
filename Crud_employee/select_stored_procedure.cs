using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_employee
{
    internal class select_stored_procedure
    {
        public select_stored_procedure() {
            try
            {
                string cs= ConfigurationManager.ConnectionStrings["database"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                
                Console.WriteLine("Enter the salary amount you want to select");
                string salary = Console.ReadLine();
                //string query = "sp_selectEmployee"; 
                SqlDataAdapter sda=new SqlDataAdapter();
                sda.SelectCommand = new SqlCommand("sp_selectEmployee", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                
                sda.SelectCommand.Parameters.AddWithValue("@Salary", salary);
                
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows) {
                    Console.WriteLine("{0} {1} {2} {3} {4} ", row[0], row[1], row[2], row[3], row[4]);
                    
                }


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
            
        }
    }
}
