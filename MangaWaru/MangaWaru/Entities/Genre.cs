namespace MangaWaru.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Slug { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? Description { get; set; }
        public ICollection<MangaGenre>? MangaGenres { get; set; }
    }
}
