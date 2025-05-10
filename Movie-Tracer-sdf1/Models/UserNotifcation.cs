namespace Movie_Tracer_sdf1.Models
{
    public class UserNotification
    {
        public int Id { get; set; }
        public int MsgId { get; set; }
        public string Content { get; set; } = string.Empty;
        public string? Link { get; set; }
        public string? Type { get; set; }
        public DateTime Date { get; set; }
    }
}
