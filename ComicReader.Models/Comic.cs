// ComicReader.Models/Comic.cs
using System;
using System.Collections.Generic;

namespace ComicReader.Models
{
    public class Comic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
        public List<Chapter> Chapters { get; set; } = new List<Chapter>();
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Rating { get; set; }
    }
}