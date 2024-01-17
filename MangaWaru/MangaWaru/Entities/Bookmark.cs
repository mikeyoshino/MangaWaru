namespace MangaWaru.Entities
{
    public class Bookmark
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int MangaId { get; set; }
        public Manga? Manga { get; set; }
    }
}
