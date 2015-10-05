using System;
using System.Collections.Generic;
using Domain.Models.Enums;

namespace Domain.Models
{
    public class Chapter : BaseEntity
    {
        public Chapter()
        {
            Persons = new List<Person>();
            Events = new List<Event>();
            Websites = new List<Website>();
            Subscriptions = new List<Subscription>();
            Correspondence = new List<Correspondence>();
            Publications = new List<Publication>();
            MediaImages = new List<MediaImage>();
            AudioVideos = new List<AudioVideo>();
            ChapterActivity = new List<ChapterActivity>();
            ChapterAddresses = new List<ChapterAddress>();
            ChapterAliases = new List<ChapterAlias>();
            LogEntries = new List<ChapterLogEntry>();
        }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime? DateFormed { get; set; }
        public DateTime? DateDisbanded { get; set; }
        public int? MovementId { get; set; }
        public bool IsHeadquarters { get; set; }

        public Status? Status { get; set; }
        public SecurityLevel SecurityLevel { get; set; }

        public virtual Movement Movement { get; set; }

        public int? OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }

        public ICollection<ChapterActivity> ChapterActivity { get; set; }
        public ICollection<Person> Persons { get; set; }
        public ICollection<Website> Websites { get; set; }
        public ICollection<Correspondence> Correspondence { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<Publication> Publications { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<AudioVideo> AudioVideos { get; set; }
        public ICollection<MediaImage> MediaImages { get; set; }
        public ICollection<ChapterAddress> ChapterAddresses { get; set; }
        public ICollection<ChapterAlias> ChapterAliases { get; set; }
        public ICollection<ChapterLogEntry> LogEntries { get; set; }


    }


    public class ChapterLogEntry : LogEntry
    {

    }

    public class ChapterAlias : Alias
    {

    }

    public class ChapterActivity : Activity
    {

    }

    public class ChapterAddress : Address
    {

    }
}