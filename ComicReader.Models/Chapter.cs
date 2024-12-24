// ComicReader.Models/Chapter.cs
using System;
using System.Collections.Generic;

namespace ComicReader.Models
{
    public class Chapter
    {
        public int Id { get; set; }
        public int ChapterNumber { get; set; }
        public string Title { get; set; }
        public List<string> Pages { get; set; } = new List<string>();
        public DateTime ReleaseDate { get; set; }
    }
}