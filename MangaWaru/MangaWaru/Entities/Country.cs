﻿namespace MangaWaru.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public ICollection<Manga>? Mangas { get; set; }
    }
}
