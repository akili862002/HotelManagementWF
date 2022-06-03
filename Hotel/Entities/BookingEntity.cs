using System;

namespace Hotel.Entities
{
    class BookingEntity
    {
        public int booking_id;
        public string desc;
        public DateTime created_at;
        public DateTime expire_at;
        public string key_code;
        public int room_id;
        public int customer_id;
        public int created_by;

        public BookingEntity()
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
