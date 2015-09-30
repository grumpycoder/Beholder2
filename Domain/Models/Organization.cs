using System;
using System.Collections.Generic;
using Domain.Models.Enums;

namespace Domain.Models
{
    public class Organization : BaseEntity
    {
        public Organization()
        {
            Chapters = new List<Chapter>();
            Persons = new List<Person>();
            Websites = new List<Website>();
            Correspondence = new List<Correspondence>();
            Events = new List<Event>();
            Publications = new List<Publication>();
            Subscriptions = new List<Subscription>();
            AudioVideos = new List<AudioVideo>();
            MediaImages = new List<MediaImage>();
            OrganizationActivity = new List<OrganizationActivity>();
            OrganizationAliases = new List<OrganizationAlias>();
            LogEntries = new List<OrganizationLogEntry>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public Status Status { get; set; }
        public DateTime? DateFormed { get; set; }
        public DateTime? DateDisbanded { get; set; }

        public ICollection<Chapter> Chapters { get; set; }
        public ICollection<Person> Persons { get; set; }
        public ICollection<Website> Websites { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<Correspondence> Correspondence { get; set; }
        public ICollection<Publication> Publications { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<AudioVideo> AudioVideos { get; set; }
        public ICollection<MediaImage> MediaImages { get; set; }

        public ICollection<OrganizationActivity> OrganizationActivity { get; set; }
        public ICollection<OrganizationAlias> OrganizationAliases { get; set; }
        public ICollection<OrganizationLogEntry> LogEntries { get; set; }

    }

    public class OrganizationLogEntry : LogEntry
    {

    }

    public class OrganizationAddress : Address
    {
    }

    public class OrganizationActivity : Activity
    {

    }

    public class OrganizationAlias : Alias
    {

    }
}