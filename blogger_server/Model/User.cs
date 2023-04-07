namespace blogger_server.Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserMobileNumber { get; set; }
        public string UserGender { get; set; }

        public string UserUserName { get; set; }
        public string UserPassword { get; set; }
    }
}
