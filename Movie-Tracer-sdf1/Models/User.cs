namespace Movie_Tracer_sdf1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? Bio { get; set; }
        public string? Location { get; set; }
        public List<string> WatchedMovies { get; set; } = new();
        public List<string> WatchedSeries { get; set; } = new();
        public List<string> FavGenres { get; set; } = new();
        public ushort Settings { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
