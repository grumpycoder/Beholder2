using System;
using System.Collections.Generic;
using Domain.Models.Enums;

namespace Domain.Models
{
    public class Correspondence: BaseEntity
    {
        public Correspondence()
        {
            LogEntries = new List<CorrespondenceLogEntry>();
            Chapters = new List<Chapter>();
            Persons = new List<Person>();
            Organizations = new List<Organization>();
            Publications = new List<Publication>();
            Websites = new List<Website>();
            Events = new List<Event>();
        }
        public string Name { get; set; }
        public string CatalogId { get; set; }

        public string City { get; set; }
        public string County { get; set; }
        public int? StateId { get; set; }

        public CorrespondenceType CorrespondenceType { get; set; }
        public DateTime? DateReceived { get; set; }
        public string Summary { get; set; }
        public Movement Movement { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }

        public ICollection<CorrespondenceLogEntry> LogEntries { get; set; }

        public ICollection<Organization> Organizations { get; set; }
        public ICollection<Chapter> Chapters { get; set; }
        public ICollection<Person> Persons { get; set; }
        public ICollection<Publication> Publications { get; set; }
        public ICollection<Website> Websites { get; set; }
        public ICollection<Event> Events { get; set; }
    }

    public class CorrespondenceLogEntry: LogEntry
    {
    }
}