using System;
using System.Collections.Generic;
using Domain.Models.Enums;

namespace Domain.Models
{
    public class MediaImage: BaseEntity
    {
        public MediaImage()
        {
            LogEntries = new List<MediaImageLogEntry>();
            Events = new List<Event>();
            Chapters = new List<Chapter>();
            Organizations = new List<Organization>();
            Persons = new List<Person>();
        }

        public string Title { get; set; }
        public string Summary { get; set; }
        public string FileName { get; set; }
        public string CatalogId { get; set; }
        public string ContactOwner { get; set; }
        public int? BatchSortOrder { get; set; }

        public string Photographer { get; set; }
        public DateTime? DatePublished { get; set; }
        public DateTime? DateTaken { get; set; }

        public string RollFrame { get; set; }
        public Movement Movement { get; set; }
        public ImageType? ImageType { get; set; }

        public byte[] Image { get; set; }
        public string MimeType { get; set; }

        public SecurityLevel SecurityLevel { get; set; }

        public ICollection<MediaImageLogEntry> LogEntries { get; set; }
        public ICollection<Organization> Organizations { get; set; }
        public ICollection<Chapter> Chapters { get; set; }
        public ICollection<Person> Persons { get; set; }
        public ICollection<Event> Events { get; set; }
        
    }

    public class MediaImageLogEntry : LogEntry
    {
    }

    public enum ImageType
    {
        Illustration = 1,
        Photograph = 2,
        Reference = 3,
        Unspecified = 11
    }
}