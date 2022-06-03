using Hotel.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Databases
{
    class ManagerDB : ConnectDB
    {
        public string table = "[manager]";

        public bool create(ManagerEntity manager)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $"insert into {table} (fullname, phone, password, birthdate, gender, address, salary) " +
                        "values (@fullname, @phone, @password, @birthdate, @gender, @address, @salary)";
            command.Parameters.AddWithValue("@fullname", manager.fullname);
            command.Parameters.AddWithValue("@phone", manager.phone);
            command.Parameters.AddWithValue("@password", manager.password);
            command.Parameters.AddWithValue("@birthdate", manager.birthdate);
            command.Parameters.AddWithValue("@gender", manager.gender);
            command.Parameters.AddWithValue("@address", manager.address);
            command.Parameters.AddWithValue("@salary", manager.salary);

            return this.executeCommand(command);
        }
        public bool checkPhone(string phone)
        {
            string query = $"SELECT COUNT(*) FROM {table} WHERE phone = {phone}";
            return executeCountQuery(query) > 0;
        }
        public SqlDataAdapter getAllAdapter(string select = "*", string search = "")
        {
            string query = $"SELECT {select} FROM {table} WHERE 1 = 1 AND fullname LIKE '%{search}%'";
            return this.executeAdapterQuery(query);
        }

        public int countUser()
        {
            return this.executeCountQuery($"SELECT COUNT(*) FROM {table}");
        }

        public bool delete(int id)
        {
            return this.executeQuery($"DELETE FROM {table} WHERE id = {id}");
        }
        public int count()
        {
            return this.executeCountQuery($"SELECT COUNT(*) FROM {table}");
        }

        public bool update(int userId, ManagerEntity user)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $"UPDATE {table} SET fullname = @fullname, phone = @phone, birthdate = @birthdate, gender = @gender, address = @address, salary = @salary, avatar = @avatar WHERE id = {userId}";
            command.Parameters.AddWithValue("@fullname", user.fullname);
            command.Parameters.AddWithValue("@phone", user.phone);
            command.Parameters.AddWithValue("@birthdate", user.birthdate);
            command.Parameters.AddWithValue("@gender", user.gender);
            command.Parameters.AddWithValue("@address", user.address);
            command.Parameters.AddWithValue("@salary", user.salary);
            return this.executeCommand(command);
        }

        public ManagerEntity getById(int userid)
        {
            DataTable dt = new DataTable();
            this.executeAdapterQuery($"SELECT manager_id, fullname, phone, avatar, is FROM {this.table}").Fill(dt);
            DataRow row = dt.Rows[0];
            if (row == null) return null;

            ManagerEntity manager = new ManagerEntity()
            {
                manager_id = row.Field<int>(0),
                fullname = row.Field<string>(1),
                phone = row.Field<string>(2),
            };
            
            return manager;
        }

        public ManagerEntity login(string phone, string password)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"SELECT  manager_id, fullname, phone FROM {table} WHERE phone = @phone AND password = @password");
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@password", password);

            this.executeAdapterCommand(cmd).Fill(dt);
            DataRow row = dt.Rows[0];
            if (row == null) return null;

            ManagerEntity manager = new ManagerEntity() {
                manager_id = row.Field<int>(0),
                fullname = row.Field<string>(1),
                phone = row.Field<string>(2),
            };
            return manager;
        }

        public SqlDataAdapter getStatisticsAdapter()
        {
            SqlCommand command = new SqlCommand("statistic_by_staff");
            command.CommandType = CommandType.StoredProcedure;
            return this.executeAdapterCommand(command);
        }
    }
}
