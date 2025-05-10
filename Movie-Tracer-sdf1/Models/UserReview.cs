namespace Movie_Tracer_sdf1.Models
{
    public class UserReview
    {
        public int Id { get; set; }
        public int ReviewId { get; set; }
        public int ContentId { get; set; }
        public string ContentType { get; set; } = "general"; 
        public string Content { get; set; } = string.Empty;
        public int Stars { get; set; }
        public DateTime Date { get; set; }
    }
}
