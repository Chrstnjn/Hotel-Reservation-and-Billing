using HotelReservation.App.BusinessLogic.Repository;
using HotelReservation.App.Model;

namespace HotelReservation.App.BusinessLogic.Controller
{
    internal class UserController
    {
        private readonly UserRepository repo = new UserRepository();

        public UserModel Login(string username, string password)
        {
            return repo.ValidateUser(username, password);
        }
    }
}
