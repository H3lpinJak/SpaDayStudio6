namespace SpaDay6.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        private string Password { get; set; }
        public string Email { get; set; }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }
}
