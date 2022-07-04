using System;
using System.Data;
using System.Data.SqlClient;

namespace Services
{
    public class District: Connection
    {
        DataTable tb = new DataTable();
        SqlDataReader reader;
        public DataTable getDistricts()
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = ("SELECT * FROM DISTRICT");
                reader = cmd.ExecuteReader();
                tb.Load(reader);
                reader.Close();
                con.Close();
            }

            return tb;
        }
    }
}
