namespace HotelReservation.App.Model
{
    public class Room
    {
         public int RoomID { get; set; }

        public string RoomNumber { get; set; } = "";

        public string RoomType { get; set; } = "";

        public string BedType { get; set; } = "";

        public decimal Price { get; set; }

        public string Status { get; set; } = "";
    }
}
