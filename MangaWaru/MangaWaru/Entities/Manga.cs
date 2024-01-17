using System.ComponentModel.DataAnnotations;

namespace MangaWaru.Entities
{
    public class Manga
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public ICollection<MangaGenre>? MangaGenres { get; set; }
        public ICollection<Bookmark>? Bookmarks { get; set; }
        public Country? Country { get; set; }
        public int CountryId { get; set; }

        public Author? Author { get; set; }
        public int AuthorId { get; set; }
        public Artist? Artist { get; set; }
        public int ArtistId { get; set; }

        public User? User { get; set; }
        public int UserId { get; set; }

        [Required]
        public string? Synopsis { get; set; }
        public string? Status { get; set; }
        public string? Type { get; set; }
        public string? Released { get; set; }
        public string? Serialization { get; set; }

        public DateTime PostedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
