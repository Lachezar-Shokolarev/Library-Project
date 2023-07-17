using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWeb.Models
{
    public class Title
    {
        public int TitleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        public string Type { get; set; }
        public List<string> Images { get; set; }
        public string MainImage { get; set; }
        public string Publisher { get; set; }
        public int? PublisherYear { get; set; }
        public Section Section { get; set; }

        public Title()
        {
            Images = new List<string>();
        }

        public Title(int titleId, string name, string description, string author, int year, string isbn, string type, List<string> images, string mainImage, string publisher, int? publisherYear, Section section)
        {
            TitleId = titleId;
            Name = name;
            Description = description;
            Author = author;
            Year = year;
            ISBN = isbn;
            Type = type;
            Images = images;
            MainImage = mainImage;
            Publisher = publisher;
            PublisherYear = publisherYear;
            Section = section;
        }
    }
}
