using HotelReservation.App.BusinessLogic.Repository;
using HotelReservation.App.Model;

namespace HotelReservation.App.BusinessLogic.Controller
{
    public class RoomController
    {
        private readonly RoomRepository repo = new RoomRepository();

        public List<Room> GetRooms()
        {
            return repo.GetAllRooms();
        }
        public bool CreateRoom(Room room)
        {
            return repo.AddRoom(room);
        }
        public bool RoomNumberExists(string roomNumber)
        {
            return repo.RoomNumberExists(roomNumber);
        }
        public bool UpdateRoom(Room room)
        {
            return repo.UpdateRoom(room);
        }
    }
}
