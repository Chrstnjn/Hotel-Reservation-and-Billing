using HotelReservation.App.BusinessLogic.Repository;
using HotelReservation.App.Model;
using System.Data;

namespace HotelReservation.App.BusinessLogic.Controller
{
    internal class ReceptionistAccountController
    {
        private readonly ReceptionistAccountRepository repo = new ReceptionistAccountRepository();

        public bool CreateHR(ReceptionistAccountModel hr)
        {
            return repo.AddHR(hr);
        }
        public List<ReceptionistAccountModel> GetAllHR()
        {
            return repo.GetAllHR();
        }
        public bool EmailExists(string email)
        {
            return repo.EmailExists(email);
        }

        public bool UsernameExists(string username)
        {
            return repo.UsernameExists(username);
        }
        public bool HRIDExists(int hrid)
        {
            return repo.HRIDExists(hrid);
        }

        public ReceptionistAccountModel GetHRByID(int hrid)
        {
            return repo.GetHRByID(hrid);
        }

        public bool UpdateHR(ReceptionistAccountModel hr)
        {
            return repo.UpdateHR(hr);
        }
        public bool DeactivateHR(int hrid)
        {
            return repo.DeactivateHR(hrid);
        }

        public DataTable GetDeactivatedHR()
        {
            return repo.GetDeactivatedHR();
        }

        public List<ReceptionistAccountModel> SearchHR(string keyword)
        {
            return repo.SearchHR(keyword);
        }


    }
}


