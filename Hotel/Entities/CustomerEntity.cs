using System;

namespace Hotel.Entities
{
    class CustomerEntity
    {
        public int customer_id;
        public string fullname;
        public string phone ;
        public string id_card;
        public DateTime created_at;
        public int created_by;

        public CustomerEntity()
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
