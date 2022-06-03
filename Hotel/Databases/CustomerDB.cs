using Hotel.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Hotel.Databases
{
    class CustomerDB : ConnectDB
    {
        public string table = "[customer]";

        public bool create(CustomerEntity cus)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $@"
                    INSERT INTO {table} (fullname, phone, identify, created_by)
                        values (@fullname, @phone, @identify, @created_by)";

            command.Parameters.AddWithValue("@fullname", cus.fullname);
            command.Parameters.AddWithValue("@phone", cus.phone);
            command.Parameters.AddWithValue("@identity", cus.identity);
            command.Parameters.AddWithValue("@created_by", cus.created_by);

            return this.executeCommand(command);
        }
        public bool isExistedPhone(string phone)
        {
            string query = $"SELECT COUNT(*) FROM {table} WHERE phone = '{phone}'";
            return executeCountQuery(query) > 0;
        }
        public SqlDataAdapter getAllAdapter(string select = "*", string search = "")
        {
            string query = $"SELECT {select} FROM {table} WHERE 1 = 1 AND fullname LIKE '%{search}%'";
            return this.executeAdapterQuery(query);
        }

        public int count()
        {
            return this.executeCountQuery($"SELECT COUNT(*) FROM {table}");
        }

        public bool delete(int cus_id)
        {
            return this.executeQuery($"DELETE FROM {table} WHERE customer_id = {cus_id}");
        }
       
        public bool update(int cus_id, CustomerEntity cus)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $@"
                UPDATE {table} SET
                    fullname = @fullname, 
                    phone = @phone, 
                    fullname = @fullname,
                    phone = @phone 
                WHERE cus_id = {cus_id}";

            command.Parameters.AddWithValue("@fullname", cus.fullname);
            command.Parameters.AddWithValue("@phone", cus.phone);
            command.Parameters.AddWithValue("@identity", cus.identity);
            command.Parameters.AddWithValue("@created_by", cus.created_by);
            return this.executeCommand(command);
        }

        public CustomerEntity getByPhone(string phone)
        {
            DataTable dt = new DataTable();
            this.executeAdapterQuery($"SELECT customer_id, fullname, phone, [identify] FROM {this.table} WHERE phone = '{phone}'").Fill(dt);

            if (dt.Rows.Count  <= 0) return null;

            DataRow row = dt.Rows[0];


            CustomerEntity cus = new CustomerEntity()
            {
                customer_id = row.Field<int>(0),
                fullname = row.Field<string>(1),
                phone = row.Field<string>(2),
                identity = row.Field<string>(3),
            };
            
            return cus;
        }

        public SqlDataAdapter getStatisticsAdapter()
        {
            SqlCommand command = new SqlCommand("statistic_by_cus");
            command.CommandType = CommandType.StoredProcedure;
            return this.executeAdapterCommand(command);
        }
    }
}
