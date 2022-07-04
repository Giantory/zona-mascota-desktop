using System;
using System.Data;
using System.Data.SqlClient;
using Models;


namespace Services
{
    public class OrderDetails:Connection
    {
        public void registerOrderDetails(int product, int quantity)
        {
            // Mensajes por defecto
            this.status = 1;
            this.message = "Proceso ejecutado correctamente";
            // Proceso General

            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                try
                {
                    // La conexión
                    con.Open();
                    // El comando
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.usp_register_orderDetails";
                    // Parametros
                    cmd.Parameters.Add("@p_productID", SqlDbType.Int).Value = product;
                    cmd.Parameters.Add("@p_quantity", SqlDbType.Int).Value = quantity;
                    cmd.Parameters.Add("@p_subtotal", SqlDbType.Money).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@p_status", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@p_message", SqlDbType.VarChar, 1000).Direction = ParameterDirection.Output;
                    // Ejecutar el procedimiento
                    cmd.ExecuteNonQuery();
                    this.status = Convert.ToInt32(cmd.Parameters["@p_status"].Value);
                    this.message = cmd.Parameters["@p_message"].Value.ToString();
                    cmd.Dispose();
                }
                catch (Exception e)
                {
                    this.status = -1;
                    this.message = e.Message;
                }
            }
        }
        public DataTable showSummary()
        {
            DataTable tb = new DataTable();
            SqlDataReader reader;
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = ("SELECT productDescription, unitPrice, quantity, subtotal FROM OrderDetails od " +
                    "JOIN Product p ON od.ProductID = p.ProductID" +
                    " WHERE od.OrderID = (SELECT MAX(OrderID) FROM Orders)");
                reader = cmd.ExecuteReader();
                tb.Load(reader);
                reader.Close();
                con.Close();
            }

            return tb;
        }
        public double showTotal()
        {
            double total;
            SqlDataReader reader;
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = ("SELECT total FROM Orders WHERE OrderID=(SELECT MAX(OrderID) FROM Orders)");
                cmd.ExecuteReader();
               
                con.Close();
            }

            return 0;
        }

    }
}
