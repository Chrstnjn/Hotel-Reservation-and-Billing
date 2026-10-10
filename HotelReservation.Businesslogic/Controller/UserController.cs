using HotelReservation.App.BusinessLogic.Repository;
using HotelReservation.Model;

namespace HotelReservation.App.BusinessLogic.Controller
{
    public class UserController
    {
        private readonly UserRepository repo = new UserRepository();

        public UserModel Login(string username, string password)
        {
            return repo.ValidateUser(username, password);
        }
    }
}
