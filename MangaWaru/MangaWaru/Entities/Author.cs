namespace MangaWaru.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Slug { get; set; }
        public ICollection<Manga>? Mangas { get; set; }
    }
}
