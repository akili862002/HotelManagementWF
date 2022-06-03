using Hotel.Entities;
using System.Data.SqlClient;

namespace Hotel.Databases
{
    class ProductDB : ConnectDB
    {
        public string table = "[product]";

        public bool createProduct(ProductEntity product)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"INSERT INTO {table} (name, price, stock, unit, created_by) VALUES (@name, @price, @stock, @unit, @created_by)";
            cmd.Parameters.AddWithValue("@name", product.name);
            cmd.Parameters.AddWithValue("@price", product.price);
            cmd.Parameters.AddWithValue("@stock", product.stock);
            cmd.Parameters.AddWithValue("@unit", product.unit);
            cmd.Parameters.AddWithValue("@created_by", product.created_by);

            return this.executeCommand(cmd);
        }

        public SqlDataAdapter getAllAdapter(string select = "*", string search = "", string filterString = "")
        {
            string query = $"SELECT {select} FROM {table} WHERE 1 = 1 ";
            if (!string.IsNullOrEmpty(search))
                query += $"AND name LIKE '%{search}%' ";
            if (!string.IsNullOrEmpty(filterString))
                query += filterString;
            return this.executeAdapterQuery(query);
        }

        public int count()
        {
            return this.executeCountQuery($"SELECT COUNT(*) FROM {table}");
        }
        public bool delete(int id)
        {
            return this.executeQuery($"DELETE FROM {table} WHERE product_id = {id}");
        }

        public bool update(int id, ProductEntity product)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"UPDATE {table} SET name = @name, price = @price, stock = @stock, unit = @unit WHERE product_id = {id}";
            cmd.Parameters.AddWithValue("@name", product.name);
            cmd.Parameters.AddWithValue("@price", product.price);
            cmd.Parameters.AddWithValue("@stock", product.stock);
            cmd.Parameters.AddWithValue("@unit", product.unit);

            return this.executeCommand(cmd);
        }
    }
}
