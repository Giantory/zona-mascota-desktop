using System;
using System.Data;
using System.Data.SqlClient;

namespace Services
{
    public class Category:Connection
    {
        public DataTable getCategories()
        {
            DataTable tb = new DataTable();
            SqlDataReader reader;
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = ("SELECT * FROM Category");
                reader = cmd.ExecuteReader();
                tb.Load(reader);
                reader.Close();
                con.Close();
            }

            return tb;
        }
    }
}
