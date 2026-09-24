using HotelReservation.App.Model;
using Microsoft.Data.SqlClient;
using System.Data;


namespace HotelReservation.App.BusinessLogic.Repository
{
    internal class UserRepository
    {
        private readonly SqlConnection conn = new SqlConnection(
        @"Data Source=CHRISTINE-LAPUZ\SQLEXPRESS;
          Initial Catalog=HotelReservationDB;
          Integrated Security=True;
          TrustServerCertificate=True");

        public UserModel ValidateUser(string username, string password)
        {
            string query = "SELECT UserID, Role FROM tblUser WHERE Username=@user AND Password=@pass";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.Parameters.AddWithValue("@user", username);
            sda.SelectCommand.Parameters.AddWithValue("@pass", password);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                return new UserModel
                {
                    UserID = Convert.ToInt32(dtable.Rows[0]["UserID"]),
                    Username = username,
                    Password = password,
                    Role = dtable.Rows[0]["Role"].ToString()
                };
            }
            return null;
        }

    }
}
