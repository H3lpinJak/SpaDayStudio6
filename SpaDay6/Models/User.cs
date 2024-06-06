namespace SpaDay6.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        private string Password { get; set; }
        public string Email { get; set; }

        public User(string u, string e, string p)
        {
            Username = u;
            Email = e;
            Password = p;
        }
    }
}
