namespace WebAppPratice.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? MName { get; set; }
        public string? StatCast { get; set; }
        public string? Director { get; set; }
        public string? Producer { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
