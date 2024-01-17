namespace MangaWaru.Entities
{
    public class Manga
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public ICollection<MangaGenre>? MangaGenres { get; set; }
    }
}
