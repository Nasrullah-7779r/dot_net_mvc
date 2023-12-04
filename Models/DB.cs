using System.Data.SqlClient;

namespace DotNetAssignment.Models
{
    public class DB
    {
      public static SqlConnection getConnnection()
        {
            string connStr = @"Server=DESKTOP-RC5M4IJ;Initial Catalog=DotNet;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connStr);

            try
                {
                 
                conn.Open();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                   
                }
                return conn;
            

        }


      public static SqlDataReader? executeCommand(string query, SqlConnection conn)
        {
            try
               {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader != null )
                {
                    return reader;
                }
                   
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return null;
            
      }

       
    }
}
