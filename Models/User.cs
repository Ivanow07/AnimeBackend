namespace AnimeBackend.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Rank { get; set; }
        public string IPAddress { get; set; }
    }
}
