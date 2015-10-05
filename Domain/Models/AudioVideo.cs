using System;
using System.Collections.Generic;
using Domain.Models.Enums;

namespace Domain.Models
{
    public class AudioVideo: BaseEntity
    {
        public AudioVideo()
        {
            LogEntries = new List<AudioVideoLogEntry>();
            Persons = new List<Person>();
            Events = new List<Event>();
            Chapters = new List<Chapter>();
            Organizations = new List<Organization>();
        }

        public string Title { get; set; }
        public string Summary { get; set; }
        public string SpeakerCommentator { get; set; }
        public string MediaLength { get; set; }

        public string CatalogId { get; set; }
        public DateTime? DateReceivedRecorded { get; set; }
        public DateTime? DateAired { get; set; }

        public string City { get; set; }
        public string County { get; set; }
        public int? StateId { get; set; }
        
        public AudioVideoType AudioVideoType { get; set; }
        public Movement Movement { get; set; }
        public SecurityLevel SecurityLevel { get; set; }

        public ICollection<AudioVideoLogEntry> LogEntries { get; set; }

        public ICollection<Organization> Organizations { get; set; }
        public ICollection<Chapter> Chapters { get; set; }
        public ICollection<Person> Persons { get; set; }
        public ICollection<Event> Events { get; set; }
    }

    public class AudioVideoLogEntry: LogEntry
    {
    }

    public enum AudioVideoType
    {
        Audio = 1,
        Video = 2,
        DigitalAudio = 11,
        DigitalVideo = 12
    }
}