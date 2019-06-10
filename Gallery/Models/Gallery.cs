using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery.Models
{
    public class Gallery
    {
        public Gallery(int id, string title, string description, string path, int position)
        {
            Id = id;
            Title = title;
            Description = description;
            Path = path;
            Position = position;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public int Position { get; set; }
    }
}