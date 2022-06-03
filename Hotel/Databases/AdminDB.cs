using Hotel.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Hotel.Databases
{
    class AdminDB: ConnectDB
    {
        string table = "admin";

        public AdminEntity login(string phone, string password)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"SELECT admin_id, phone FROM {table} WHERE phone = @phone AND password = @password");
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@password", password);

            this.executeAdapterCommand(cmd).Fill(dt);
            DataRow row = dt.Rows[0];
            if (row == null) return null;

            AdminEntity admin = new AdminEntity()
            {
                admin_id = row.Field<int>(0),
                phone = row.Field<string>(1),
            };
            return admin;
        }
    }
}
