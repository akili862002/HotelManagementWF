using Hotel.Entities;
using System.Data.SqlClient;

namespace Hotel.Databases
{
    class BillDB : ConnectDB
    {
        public bool create(BillEntity bill)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"INSERT INTO [bill] (booking_id, total_price, [desc]) VALUES (@booking_id, @total_price, @desc)";
            cmd.Parameters.AddWithValue("@booking_id", bill.booking_id);
            cmd.Parameters.AddWithValue("@total_price", bill.total_price);
            cmd.Parameters.AddWithValue("@desc", bill.desc);
            return this.executeCommand(cmd);
        }
    }
}
