namespace MangaWaru.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public UserRole? UserRole { get; set; }
        public int UserRoleId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastLogin { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Manga>? Mangas { get; set; }
    }
}
