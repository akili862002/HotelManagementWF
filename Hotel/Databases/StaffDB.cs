using Hotel.Entities;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Hotel.Databases
{
    class StaffDB : ConnectDB
    {
        public string table = "[staff]";

        public bool create(StaffEntity staff)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $@"
                    INSERT INTO {table} (fullname, phone, password, birthdate, gender, address, salary, is_labor, is_reception)
                        values (@fullname, @phone, @password, @birthdate, @gender, @address, @salary, @is_labor, @is_reception)";
            command.Parameters.AddWithValue("@fullname", staff.fullname);
            command.Parameters.AddWithValue("@phone", staff.phone);
            command.Parameters.AddWithValue("@password", staff.password);
            command.Parameters.AddWithValue("@birthdate", staff.birthdate);
            command.Parameters.AddWithValue("@gender", staff.gender);
            command.Parameters.AddWithValue("@address", staff.address);
            command.Parameters.AddWithValue("@salary", staff.salary);
            command.Parameters.AddWithValue("@is_labor", staff.is_labor);
            command.Parameters.AddWithValue("@is_reception", staff.is_reception);

            return this.executeCommand(command);
        }
        public bool isExistedPhone(string phone)
        {
            string query = $"SELECT COUNT(*) FROM {table} WHERE phone = '{phone}'";
            return executeCountQuery(query) > 0;
        }
        public SqlDataAdapter getAllAdapter(string select = "*", string search = "", string condition = "")
        {
            string query = $"SELECT {select} FROM {table} WHERE 1 = 1 AND fullname LIKE N'%{search}%' {condition}";
            return this.executeAdapterQuery(query);
        }

        public int countUser()
        {
            return this.executeCountQuery($"SELECT COUNT(*) FROM {table}");
        }

        public bool delete(int staff_id)
        {
            return this.executeQuery($"DELETE FROM {table} WHERE staff_id = {staff_id}");
        }
        public int count()
        {
            return this.executeCountQuery($"SELECT COUNT(*) FROM {table}");
        }

        public bool update(int staff_id, StaffEntity staff)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $@"
                UPDATE {table} SET
                    fullname = @fullname, 
                    phone = @phone, 
                    birthdate = @birthdate, 
                    gender = @gender, 
                    address = @address,
                    salary = @salary,
                    is_labor = @is_labor,
                    is_reception = @is_reception
                WHERE staff_id = {staff_id}";

            command.Parameters.AddWithValue("@fullname", staff.fullname);
            command.Parameters.AddWithValue("@phone", staff.phone);
            command.Parameters.AddWithValue("@birthdate", staff.birthdate);
            command.Parameters.AddWithValue("@gender", staff.gender);
            command.Parameters.AddWithValue("@address", staff.address);
            command.Parameters.AddWithValue("@salary", staff.salary);
            command.Parameters.AddWithValue("@is_labor", staff.is_labor);
            command.Parameters.AddWithValue("@is_reception", staff.is_reception);
            return this.executeCommand(command);
        }

        public StaffEntity getById(int staff_id)
        {
            DataTable dt = new DataTable();
            this.executeAdapterQuery($"SELECT staff_id, fullname, phone, avatar FROM {this.table} WHERE staff_id ={staff_id}").Fill(dt);
            DataRow row = dt.Rows[0];
            if (row == null) return null;

            StaffEntity staff = new StaffEntity()
            {
                staff_id = row.Field<int>(0),
                fullname = row.Field<string>(1),
                phone = row.Field<string>(2),
            };
            
            return staff;
        }
        public List<StaffEntity> getAllList(string condition = "")
        {
            DataTable dt = new DataTable();
            this.executeAdapterQuery($"SELECT staff_id, fullname, phone FROM {this.table} WHERE 1 = 1 {condition}").Fill(dt);

            List<StaffEntity> result = new List<StaffEntity>();
            foreach (DataRow row in dt.Rows)
            {
                StaffEntity staff = new StaffEntity()
                {
                    staff_id = row.Field<int>(0),
                    fullname = row.Field<string>(1),
                    phone = row.Field<string>(2),
                };
                result.Add(staff);
            }
            return result;
        }
        public StaffEntity login(string phone, string password)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"SELECT  staff_id, fullname, phone, is_labor, is_reception FROM {table} WHERE phone = @phone AND password = @password AND is_reception = 1");
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@password", password);

            this.executeAdapterCommand(cmd).Fill(dt);
            DataRow row = dt.Rows[0];
            if (row == null) return null;

            StaffEntity staff = new StaffEntity() {
                staff_id = row.Field<int>(0),
                fullname = row.Field<string>(1),
                phone = row.Field<string>(2),
                is_labor = row.Field<bool>(3),
                is_reception = row.Field<bool>(4)
            };
            return staff;
        }

        public SqlDataAdapter getStatisticsAdapter()
        {
            SqlCommand command = new SqlCommand("statistic_by_staff");
            command.CommandType = CommandType.StoredProcedure;
            return this.executeAdapterCommand(command);
        }
    }
}
