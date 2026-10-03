using HotelReservation.App.Model;
using Microsoft.Data.SqlClient;

namespace HotelReservation.App.BusinessLogic.Repository
{
    public class RoomRepository
    {
        private readonly SqlConnection conn = new SqlConnection(
          @"Data Source=CHRISTINE-LAPUZ\SQLEXPRESS;
          Initial Catalog=HotelReservationDB;
          Integrated Security=True;
          TrustServerCertificate=True");


        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();

            string query = "SELECT * FROM Room";

            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                rooms.Add(new Room
                {
                    RoomID = Convert.ToInt32(reader["RoomID"]),
                    RoomNumber = reader["RoomNumber"].ToString(),
                    RoomType = reader["RoomType"].ToString(),
                    BedType = reader["BedType"].ToString(),
                    Price = Convert.ToDecimal(reader["Price"]),
                    Status = reader["Status"].ToString()
                });
            }

            conn.Close();

            return rooms;
        }

        public bool AddRoom(Room room)
        {
            string query = @"INSERT INTO Room
                    (RoomNumber, RoomType, BedType, Price, Status)
                    VALUES
                    (@RoomNumber, @RoomType, @BedType, @Price, @Status)";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
            cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
            cmd.Parameters.AddWithValue("@BedType", room.BedType);
            cmd.Parameters.AddWithValue("@Price", room.Price);
            cmd.Parameters.AddWithValue("@Status", room.Status);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            return rows > 0;
        }

        public bool RoomNumberExists(string roomNumber)
        {
            string query = "SELECT COUNT(*) FROM Room WHERE RoomNumber = @RoomNumber";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);

            conn.Open();

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count > 0;
        }

        public bool UpdateRoom(Room room)
        {
            string query = @"UPDATE Room
                     SET RoomType = @RoomType,
                         BedType = @BedType,
                         Price = @Price
                     WHERE RoomNumber = @RoomNumber";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
            cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
            cmd.Parameters.AddWithValue("@BedType", room.BedType);
            cmd.Parameters.AddWithValue("@Price", room.Price);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            return rows > 0;
        }
    }
}
