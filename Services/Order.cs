using System;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace Services
{
    public class Order:Connection
    {
        public void registerOrder(int employee, int customer)
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
                    cmd.CommandText = "dbo.usp_register_order";
                    // Parametros
                    cmd.Parameters.Add("@p_employee", SqlDbType.Int).Value = employee;
                    cmd.Parameters.Add("@p_customer", SqlDbType.Int).Value = customer;
                    cmd.Parameters.Add("@p_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@p_status", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@p_message", SqlDbType.VarChar, 1000).Direction = ParameterDirection.Output;
                    // Ejecutar el procedimiento
                    cmd.ExecuteNonQuery();
                    this.status = Convert.ToInt32(cmd.Parameters["@p_status"].Value);
                    this.message = cmd.Parameters["@p_message"].ToString();
                    cmd.Dispose();
                }
                catch (Exception e)
                {
                    this.status = -1;
                    this.message = e.Message;
                }
            }
        }
        public double showTotal()
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = ("SELECT productDescription, unitPrice, quantity, subtotal FROM OrderDetails od " +
                    "JOIN Product p ON od.ProductID = p.ProductID" +
                    " WHERE od.OrderID = (SELECT MAX(OrderID) FROM Orders)");
                con.Close();
            }

            return 0;
        }
    }
}
