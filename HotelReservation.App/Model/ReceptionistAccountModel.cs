namespace HotelReservation.App.Model
{
    internal class ReceptionistAccountModel
    {
        public int HRID { get; set; }

        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public string MiddleInitial { get; set; } = "";

        public string ContactNo { get; set; } = "";

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; } = "";

        public string Username { get; set; } = "";

        public string Password { get; set; } = "";
    }
}

