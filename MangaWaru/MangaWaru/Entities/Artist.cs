namespace MangaWaru.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Manga>? Mangas { get; set; }
    }
}
