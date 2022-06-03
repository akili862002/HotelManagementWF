using Hotel.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel.Databases
{
    class BookingDB : ConnectDB
    {
        string table = "[booking]";
        public int create(BookingEntity booking)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $@"
                INSERT INTO [booking] (expire_at, key_code, room_id, customer_id, created_by) OUTPUT INSERTED.booking_id 
                    VALUES (@expire_at, @key_code, @room_id, @customer_id, @created_by)
            ";
            cmd.Parameters.AddWithValue("@expire_at", booking.expire_at);
            cmd.Parameters.AddWithValue("@key_code", booking.key_code);
            cmd.Parameters.AddWithValue("@room_id", booking.room_id);
            cmd.Parameters.AddWithValue("@customer_id", booking.customer_id);
            cmd.Parameters.AddWithValue("@created_by", booking.created_by);
            return this.executeCommandAndTakeReturn(cmd);
        }
        public bool update(int booking_id, BookingEntity order)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $@"
                UPDATE [booking] SET expire_at = @expire_at, key_code = @key_code, room_id = @room_id, customer_id = @customer_id, created_by = @created_by
                WHERE booking_id = {booking_id}
            ";
            cmd.Parameters.AddWithValue("@expire_at", order.expire_at);
            cmd.Parameters.AddWithValue("@key_code", order.key_code);
            cmd.Parameters.AddWithValue("@room_id", order.room_id);
            cmd.Parameters.AddWithValue("@customer_id", order.customer_id);
            cmd.Parameters.AddWithValue("@created_by", order.created_by);
            return this.executeCommand(cmd);
        }
        public bool cancel(int booking_id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $@"
                UPDATE [booking] SET is_cancel = @is_cancel
                WHERE booking_id = {booking_id}
            ";
            cmd.Parameters.AddWithValue("@is_cancel", true);
            return this.executeCommand(cmd);
        }

        public int getOrderNumberOfCurrentTable(int table_id)
        {
            string query = $@"
				SELECT booking.booking_id
                FROM [booking] LEFT JOIN bill ON booking.booking_id = bill.booking_id
                WHERE booking.room_id = {table_id}
            ";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            return this.executeCommandAndTakeReturn(cmd);
        }

        public int getTotalPriceOfOrder(int order_number)
        {
            return this.executeCountQuery($"SELECT dbo.get_total_price_of_order({order_number})");
        }
        public int getCountOder()
        {
            return executeCountQuery("SELECT dbo.count_order_today()");
        }
        public int getCountRevenue()
        {
            return executeCountQuery("SELECT dbo.sum_revenue_today()");
        }
        public int getCountCost()
        {
            return executeCountQuery("SELECT dbo.sum_cost_today()");
        }

        public SqlDataAdapter getAllOrdersAdapter(string selectString = "*")
        {
            SqlCommand command = new SqlCommand($@"
                SELECT	
                    {selectString}
                FROM [order_item]
                JOIN booking ON order_item.booking_id = booking.booking_id
                LEFT JOIN bill ON booking.booking_id = bill.booking_id
                ORDER BY [order_item].created_at DESC
            ");
            return this.executeAdapterCommand(command);
        }

        public BookingEntity getById(int booking_id)
        {
            DataTable dt = new DataTable();

            this.executeAdapterQuery($@"
                SELECT booking_id, created_at, expire_at, key_code, room_id, customer_id FROM booking
                WHERE booking_id = {booking_id}
            ").Fill(dt);

            if (dt.Rows.Count <= 0) return null;

            DataRow row = dt.Rows[0];

            BookingEntity booking = new BookingEntity() { 
                booking_id = row.Field<int>(0),
                created_at = DateTime.Parse(row.Field<object>(1).ToString()),
                expire_at = DateTime.Parse(row.Field<object>(2).ToString()),
                key_code = row.Field<string>(3),
                room_id = row.Field<int>(4),
                customer_id = row.Field<int>(5),
            };

            return booking;
        }
    }
}
