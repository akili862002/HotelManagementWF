using Hotel.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Databases
{
    class RoomDB : ConnectDB
    {
        public string tableName = "[room]";

        public bool create(RoomEntity room)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"INSERT INTO {this.tableName} (name, [desc], price_per_hour) VALUES (@name, @desc, @price_per_hour)";
            cmd.Parameters.AddWithValue("@name", room.name);
            cmd.Parameters.AddWithValue("@desc", room.desc);
            cmd.Parameters.AddWithValue("@price_per_hour", room.price_per_hour);
            return this.executeCommand(cmd);
        }

        public SqlDataAdapter getAllAdapter(string select = "*", string search = "")
        {
            string query = $@"
                    SELECT {select}
                    FROM {tableName} LEFT JOIN 
                    (
                        booking LEFT JOIN bill ON booking.booking_id = bill.booking_id
                    )
                    ON room.room_id = booking.room_id AND bill.booking_id IS NULL
                    WHERE 1 = 1
                    GROUP BY room.room_id, room.[name], booking.booking_id, room.[desc], price_per_hour
                ";
            if (!string.IsNullOrEmpty(search))
            {
                query += $" AND name LIKE '%{search}%'";
            }
            return this.executeAdapterQuery(query);
        }
        public SqlDataReader getAllReader(string select = "*", string search = "")
        {
            string query = $"SELECT {select} FROM {tableName} WHERE 1 = 1 ";
            if (!string.IsNullOrEmpty(search))
            {
                query += $" AND name LIKE '%{search}%'";
            }
            return this.executeReaderQuery(query);
        }

        public int count()
        {
            return this.executeCountQuery($"SELECT COUNT(*) FROM {tableName}");
        }

        public bool delete(int id)
        {
            return this.executeQuery($"DELETE FROM {tableName} WHERE room_id = {id}");
        }

        public bool update(int room_id, RoomEntity room)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $"UPDATE {tableName} SET name = @name, [desc] = @desc, price_per_hour = @price_per_hour WHERE room_id = {room_id}";
            command.Parameters.AddWithValue("@name", room.name);
            command.Parameters.AddWithValue("@desc", room.desc);
            command.Parameters.AddWithValue("@price_per_hour", room.price_per_hour);
            return this.executeCommand(command);
        }
    }
}
