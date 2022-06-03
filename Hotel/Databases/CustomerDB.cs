using Hotel.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Hotel.Databases
{
    class CustomerDB : ConnectDB
    {
        public string table = "[customer]";

        public int create(CustomerEntity cus)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $@"
                    INSERT INTO {table} (fullname, phone, [id_card], pic, created_by)
                    OUTPUT INSERTED.customer_id 
                    VALUES (@fullname, @phone, @id_card, @pic, @created_by)
            ";

            command.Parameters.AddWithValue("@fullname", cus.fullname);
            command.Parameters.AddWithValue("@phone", cus.phone);
            command.Parameters.AddWithValue("@id_card", cus.id_card);
            command.Parameters.AddWithValue("@pic", cus.pic);
            command.Parameters.AddWithValue("@created_by", cus.created_by);

            return this.executeCommandAndTakeReturn(command);
        }
        public bool isExistedPhone(string phone)
        {
            string query = $"SELECT COUNT(*) FROM {table} WHERE phone = '{phone}'";
            return executeCountQuery(query) > 0;
        }
        public SqlDataAdapter getAllAdapter(string select = "*", string search = "")
        {
            string query = $"SELECT {select} FROM {table} WHERE 1 = 1 AND fullname LIKE N'%{search}%'";
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
                    pic = @pic, 
                    [id_card] = @id_card
                WHERE customer_id = {cus_id}";

            command.Parameters.AddWithValue("@fullname", cus.fullname);
            command.Parameters.AddWithValue("@phone", cus.phone);
            command.Parameters.AddWithValue("@pic", cus.pic);
            command.Parameters.AddWithValue("@id_card", cus.id_card);
            return this.executeCommand(command);
        }

        public CustomerEntity getByPhone(string phone)
        {
            DataTable dt = new DataTable();
            this.executeAdapterQuery($"SELECT customer_id, fullname, phone, [id_card], pic FROM {this.table} WHERE phone = '{phone}'").Fill(dt);

            if (dt.Rows.Count  <= 0) return null;

            DataRow row = dt.Rows[0];


            CustomerEntity cus = new CustomerEntity()
            {
                customer_id = row.Field<int>(0),
                fullname = row.Field<string>(1),
                phone = row.Field<string>(2),
                id_card = row.Field<string>(3),
                pic = row.Field<string>(4),
            };
            
            return cus;
        }

        public CustomerEntity getById(int customer_id)
        {
            DataTable dt = new DataTable();
            this.executeAdapterQuery($"SELECT customer_id, fullname, phone, [id_card], pic FROM {this.table} WHERE customer_id = {customer_id}").Fill(dt);

            if (dt.Rows.Count <= 0) return null;

            DataRow row = dt.Rows[0];


            CustomerEntity cus = new CustomerEntity()
            {
                customer_id = row.Field<int>(0),
                fullname = row.Field<string>(1),
                phone = row.Field<string>(2),
                id_card = row.Field<string>(3),
                pic = row.Field<string>(4),
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
