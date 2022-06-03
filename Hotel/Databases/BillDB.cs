using Hotel.Entities;
using System.Data.SqlClient;

namespace Hotel.Databases
{
    class BillDB : ConnectDB
    {
        string tableName = "[bill]";

        public bool create(BillEntity bill)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"INSERT INTO {this.tableName} (order_number, total_price, description) values (@order_number, @total_price, @description)";
            cmd.Parameters.AddWithValue("@order_number", bill.order_number);
            cmd.Parameters.AddWithValue("@total_price", bill.total_price);
            cmd.Parameters.AddWithValue("@description", bill.description);
            return this.executeCommand(cmd);
        }
    }
}
