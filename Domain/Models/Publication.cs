using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using Domain.Models.Enums;

namespace Domain.Models
{
    public class Publication: BaseEntity
    {
        public Publication()
        {
            LogEntries = new List<PublicationLogEntry>();
            Chapters = new List<Chapter>();
            Events = new List<Event>();
            Websites = new List<Website>();
            Correspondence = new List<Correspondence>();
            Subscriptions = new List<Subscription>();
            Organizations = new List<Organization>();
            Persons = new List<Person>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? DatePublished { get; set; }
        public int? PublicationTypeId { get; set; }
        public string Author { get; set; }
        public Movement Movement { get; set; }
        public string Summary { get; set; }
        public string CatalogId { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public int? StateId { get; set; }


        public PublicationType PublicationType { get; set; }
        public RenewalType? RenewalType { get; set; }
        public SecurityLevel SecurityLevel { get; set; }

        public ICollection<PublicationLogEntry> LogEntries { get; set;  }

        public ICollection<Organization> Organizations { get; set; }
        public ICollection<Chapter> Chapters { get; set; }
        public ICollection<Person> Persons { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<Website> Websites { get; set; }
        public ICollection<Correspondence> Correspondence { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }


    }

    public class PublicationLogEntry: LogEntry
    {
    }

    public enum RenewalType
    {
        AutoRenewing = 1,
        SingleUse = 2,
        Yearly = 3,
        Monthly = 4,
        NoPermissions = 5
    }
}