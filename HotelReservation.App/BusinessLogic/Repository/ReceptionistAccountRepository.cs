using Microsoft.Data.SqlClient;
using HotelReservation.App.Model;
using System.Data;
using System.Text;

namespace HotelReservation.App.BusinessLogic.Repository
{
    internal class ReceptionistAccountRepository
    {
        private readonly SqlConnection conn =
            new SqlConnection(
         @"Data Source=CHRISTINE-LAPUZ\SQLEXPRESS;
          Initial Catalog=HotelReservationDB;
          Integrated Security=True;
          TrustServerCertificate=True");

        public bool AddHR(ReceptionistAccountModel hr)
        {
            conn.Open();

            // Insert into HR table
            string query = @"INSERT INTO HR
            (HRID, FirstName, LastName, MiddleInitial,
             ContactNo, DateOfBirth, Email,
             Username, Password)
            VALUES
            (@HRID, @FN, @LN, @MI,
             @NO, @DOB, @Email,
             @Username, @Password)";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@HRID", hr.HRID);
            cmd.Parameters.AddWithValue("@FN", hr.FirstName);
            cmd.Parameters.AddWithValue("@LN", hr.LastName);
            cmd.Parameters.AddWithValue("@MI", hr.MiddleInitial);
            cmd.Parameters.AddWithValue("@NO", hr.ContactNo);
            cmd.Parameters.AddWithValue("@DOB", hr.DateOfBirth);
            cmd.Parameters.AddWithValue("@Email", hr.Email);
            cmd.Parameters.AddWithValue("@Username", hr.Username);
            cmd.Parameters.AddWithValue("@Password", hr.Password);

            int rows = cmd.ExecuteNonQuery();

            // Insert into Login_new table
            string loginQuery = @"INSERT INTO tblUser
            (username, password, role)
            VALUES
            (@Username, @Password, @Role)";

            SqlCommand loginCmd =
                new SqlCommand(loginQuery, conn);

            loginCmd.Parameters.AddWithValue("@Username", hr.Username);
            loginCmd.Parameters.AddWithValue("@Password", hr.Password);
            loginCmd.Parameters.AddWithValue("@Role", "Receptionist");

            loginCmd.ExecuteNonQuery();

            conn.Close();

            return rows > 0;
        }
        public bool EmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM HR WHERE Email = @Email";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Email", email);

            conn.Open();

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count > 0;
        }

        public bool UsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM HR WHERE Username = @Username";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", username);

            conn.Open();

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count > 0;
        }
        public bool HRIDExists(int hrid)
        {
            string query = "SELECT COUNT(*) FROM HR WHERE HRID = @HRID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@HRID", hrid);

            conn.Open();

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count > 0;
        }
        public bool UpdateHR(ReceptionistAccountModel hr)
        {
            string query = @"UPDATE HR
                    SET FirstName = @FN,
                        LastName = @LN,
                        MiddleInitial = @MI,
                        ContactNo = @NO,
                        DateOfBirth = @DOB,
                        Email = @Email,
                        Username = @Username,
                        Password = @Password
                    WHERE HRID = @HRID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@HRID", hr.HRID);
            cmd.Parameters.AddWithValue("@FN", hr.FirstName);
            cmd.Parameters.AddWithValue("@LN", hr.LastName);
            cmd.Parameters.AddWithValue("@MI", hr.MiddleInitial);
            cmd.Parameters.AddWithValue("@NO", hr.ContactNo);
            cmd.Parameters.AddWithValue("@DOB", hr.DateOfBirth);
            cmd.Parameters.AddWithValue("@Email", hr.Email);
            cmd.Parameters.AddWithValue("@Username", hr.Username);
            cmd.Parameters.AddWithValue("@Password", hr.Password);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            return rows > 0;
        }
        public ReceptionistAccountModel GetHRByID(int hrid)
        {
            string query = "SELECT * FROM HR WHERE HRID = @HRID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@HRID", hrid);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            ReceptionistAccountModel hr = null;

            if (reader.Read())
            {
                hr = new ReceptionistAccountModel
                {
                    HRID = Convert.ToInt32(reader["HRID"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    MiddleInitial = reader["MiddleInitial"].ToString(),
                    ContactNo = reader["ContactNo"].ToString(),
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                    Email = reader["Email"].ToString(),
                    Username = reader["Username"].ToString(),
                    Password = reader["Password"].ToString()
                };
            }

            conn.Close();

            return hr;
        }

        public bool DeactivateHR(int hrid)
        {
            conn.Open();

            SqlTransaction trans = conn.BeginTransaction();

            try
            {
                // Move HR record to DeactivatedHR
                string moveQuery = @"
        INSERT INTO DeactivatedHR
        (
            HRID,
            FirstName,
            LastName,
            MiddleInitial,
            ContactNo,
            DateOfBirth,
            Email,
            Username,
            Password,
            DateDeactivated
        )
        SELECT
            HRID,
            FirstName,
            LastName,
            MiddleInitial,
            ContactNo,
            DateOfBirth,
            Email,
            Username,
            Password,
            GETDATE()
        FROM HR
        WHERE HRID = @HRID";

                SqlCommand moveCmd =
                    new SqlCommand(moveQuery, conn, trans);

                moveCmd.Parameters.AddWithValue("@HRID", hrid);

                moveCmd.ExecuteNonQuery();

                // Delete login account
                string deleteLogin = @"
            DELETE FROM tblUser
            WHERE Username =
            (
                SELECT Username
                FROM HR
                WHERE HRID = @HRID
            )";

                SqlCommand loginCmd =
                    new SqlCommand(deleteLogin, conn, trans);

                loginCmd.Parameters.AddWithValue("@HRID", hrid);

                loginCmd.ExecuteNonQuery();

                // Delete from active HR
                string deleteHR =
                    "DELETE FROM HR WHERE HRID = @HRID";

                SqlCommand deleteCmd =
                    new SqlCommand(deleteHR, conn, trans);

                deleteCmd.Parameters.AddWithValue("@HRID", hrid);

                int rows = deleteCmd.ExecuteNonQuery();

                trans.Commit();

                conn.Close();

                return rows > 0;
            }
            catch
            {
                trans.Rollback();
                conn.Close();

                return false;
            }
        }

        public DataTable GetDeactivatedHR()
        {
            DataTable table = new DataTable();

            string query =
                "SELECT * FROM DeactivatedHR ORDER BY DateDeactivated DESC";

            SqlDataAdapter da =
                new SqlDataAdapter(query, conn);

            da.Fill(table);

            return table;
        }
        public List<ReceptionistAccountModel> SearchHR(string keyword)
        {
            List<ReceptionistAccountModel> hrList =
                new List<ReceptionistAccountModel>();

            string query = @"
    SELECT *
    FROM HR
    WHERE
        CAST(HRID AS VARCHAR) LIKE '%' + @Keyword + '%'
        OR FirstName LIKE '%' + @Keyword + '%'
        OR LastName LIKE '%' + @Keyword + '%'
        OR Username LIKE '%' + @Keyword + '%'
        OR Email LIKE '%' + @Keyword + '%'";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Keyword", keyword);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                hrList.Add(new ReceptionistAccountModel
                {
                    HRID = Convert.ToInt32(reader["HRID"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    MiddleInitial = reader["MiddleInitial"].ToString(),
                    ContactNo = reader["ContactNo"].ToString(),
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                    Email = reader["Email"].ToString(),
                    Username = reader["Username"].ToString(),
                    Password = reader["Password"].ToString()
                });
            }

            conn.Close();

            return hrList;
        }
        public List<ReceptionistAccountModel> GetAllHR()
        {
            List<ReceptionistAccountModel> hrList =
                new List<ReceptionistAccountModel>();

            string query = "SELECT * FROM HR";

            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                hrList.Add(new ReceptionistAccountModel
                {
                    HRID = Convert.ToInt32(reader["HRID"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    MiddleInitial = reader["MiddleInitial"].ToString(),
                    ContactNo = reader["ContactNo"].ToString(),
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                    Email = reader["Email"].ToString(),
                    Username = reader["Username"].ToString(),
                    Password = reader["Password"].ToString()
                });
            }

            conn.Close();

            return hrList;
        }
    }
}
