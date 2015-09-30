using System;
using System.Collections.Generic;
using Domain.Models.Enums;

namespace Domain.Models
{
    public class Event: BaseEntity
    {
        public string Name { get; set; }
        public string Summary { get; set; }
        public DocumentationType DocumentationType { get; set; }
        //TODO: Need to be bitwise. Contains multiple types. Should not exist in seperate table?
        public EventType EventType { get; set; }

        public DateTime? EventDate { get; set; }
        public Status Status { get; set; }
        public Movement Movement { get; set; }
        public SecurityLevel SecurityLevel { get; set; }

        public ICollection<Organization> Organizations { get; set; }
        public ICollection<Chapter> Chapters { get; set; }
        public ICollection<Person> Persons { get; set; }
        public ICollection<EventActivity> EventActivity { get; set; }
        public ICollection<EventLogEntry> LogEntries { get; set; }
        public ICollection<EventAddress> EventAddresses { get; set; }
        public ICollection<Publication> Publications { get; set; }
        public ICollection<MediaImage> MediaImages { get; set; }
        public ICollection<AudioVideo> AudioVideos { get; set; }
        public ICollection<Correspondence> Correspondences { get; set; }
        public ICollection<Event> Events { get; set; }
    }

    public class EventAddress : Address
    {
        
    }

    public class EventActivity : Activity
    {

    }

    public class EventLogEntry : LogEntry
    {

    }

}