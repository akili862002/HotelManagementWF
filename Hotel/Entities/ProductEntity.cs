using System;

namespace Hotel.Entities
{
    class ProductEntity
    {
        public int product_id;
        public string name;
        public long price;
        public int stock;
        public string unit;
        public int created_by;
        public DateTime created_at;
        public DateTime updated_at;

        public ProductEntity()
        {
            if (Program.Global.staff != null)
                this.created_by = Program.Global.staff.staff_id;
            else
          if (Program.Global.manager != null)
                this.created_by = Program.Global.manager.manager_id;
            else
          if (Program.Global.admin != null)
                this.created_by = Program.Global.admin.admin_id;
        }
    }
}
