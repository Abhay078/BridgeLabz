using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Reflection;
using System.Data;
using System.Transactions;

namespace Review2
{
    public class Program
    {
        public void RetrieveStudents()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
                
                SqlConnection con = new SqlConnection(cs);
                string query = "Select Name,Age,Grade from Students Where Grade>85";
                SqlDataAdapter sda=new SqlDataAdapter(query, con);
                DataTable dt= new DataTable();
                sda.Fill(dt);
                foreach(DataRow row in dt.Rows) {
                    Console.WriteLine("{0} {1} {2}", row[0], row[1], row[2]);
                }


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void RankStudent<T>()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

                SqlConnection con = new SqlConnection(cs);
                string query = "";
                if(typeof(T)==typeof(int))
                {
                    query = "SELECT Name, Grade FROM Students ORDER BY CAST(Grade AS  INT) DESC";
                }
                else
                {
                    query = "SELECT Name, Grade FROM Students ORDER BY  DESC";
                }
                
               
                
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine("{0}", row[0]);

                }
                


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("press 1 for retrive students\n press 2 for ranking student");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Program program= new Program();

                    program.RetrieveStudents();
                    break;
                case 2:
                    Program program1 = new Program();
                    program1.RankStudent<int>();
                    break;

            }
            
            
            //Console.WriteLine("For T as Double");
            //program.RankStudent<double>();

        }
    }
}
