namespace Hotel.Entities
{
    class RoomEntity
    {
        public int room_id;
        public string name;
        public string desc;
        public long price_per_hour;

        // Abstract properties
        public bool is_busy;
        public int order_number;
    }
}
