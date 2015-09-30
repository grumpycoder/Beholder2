using System;
using System.Collections.Generic;
using Domain.Models.Enums;

namespace Domain.Models
{
    public class Website: BaseEntity
    {

        public string Name { get; set; }
        public WebsiteType Type { get; set; }
        public string Url { get; set; }
        public string Summary { get; set; }

        public DateTime? DateDiscovered { get; set; }
        public DateTime? DatePublished { get; set; }
        public DateTime? DateOffline { get; set; }

        public string WebsiteType { get; set; }

        public Movement Movement { get; set; }
        public Status Status { get; set; }
        public string WhoIs { get; set; }

        public ICollection<WebsiteLogEntry> LogEntries { get; set; }
        public ICollection<Person> Persons { get; set; }
        public ICollection<Chapter> Chapters { get; set; }
        public ICollection<Organization> Organizations { get; set; }
        public ICollection<Publication> Publications { get; set; }
        public ICollection<Correspondence> Correspondences { get; set; }
    }

    public class WebsiteLogEntry: LogEntry
    {
    }
}