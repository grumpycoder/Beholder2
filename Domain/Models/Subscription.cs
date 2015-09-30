using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Subscription: BaseEntity
    {
        public string Name { get; set; }
        public string Rate { get; set; }
        public DateTime? RenewalDate { get; set; }
        public DateTime? SubscriptionDate { get; set; }

        public string MailerName { get; set; }
        public string MailerStreet { get; set; }
        public string MailerCity { get; set; }
        public string MailerState { get; set; }
        public string MailerZipCode { get; set; }
        
        public ICollection<Chapter> Chapter { get; set; }
        public ICollection<Organization> Organization { get; set; }
        public ICollection<Publication> Publications { get; set; }

        public ICollection<SubscriptionLogEntry> LogEntries { get; set; }

    }

    public class SubscriptionLogEntry:LogEntry
    {
    }
}