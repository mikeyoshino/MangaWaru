namespace MangaWaru.Entities
{
    public class MangaGenre
    {
        public Guid Id { get; set; }
        public Manga? Manga { get; set; }
        public int MangaId { get; set; }

        public Genre? Genre { get; set; }
        public int GenreId { get; set; }

    }
}
