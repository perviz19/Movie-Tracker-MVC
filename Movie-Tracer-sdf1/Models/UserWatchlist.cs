namespace Movie_Tracer_sdf1.Models
{
    public class UserWatchlist
    {
        public int Id { get; set; }
        public int ContentId { get; set; }
        public string ContentName { get; set; } = string.Empty;
        public string ContentOverview { get; set; } = string.Empty;
        public string ContentType { get; set; } = "general"; 
        public DateTime AddedDate { get; set; }
    }

}
