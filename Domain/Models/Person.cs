
using System;
using System.Collections.Generic;
using Domain.Models.Enums;

namespace Domain.Models
{
    public class Person : BaseEntity
    {
        public Person()
        {
            OnlineAlias = new List<OnlineAlias>();
            Events = new List<Event>();
            Websites = new List<Website>();
            LogEntries = new List<PersonLogEntry>();
            PersonAddresses = new List<PersonAddress>();
            PersonAliases = new List<PersonAlias>();
            Correspondence = new List<Correspondence>();
            Publications = new List<Publication>();
            Chapters = new List<Chapter>();
            Organizations = new List<Organization>();
            MediaImages = new List<MediaImage>();
            AudioVideos = new List<AudioVideo>();
        }
        public int? PrefixId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {MiddleName} {LastName}";
        public string ReverseFullName => $"{LastName}, {FirstName} {MiddleName}";

        public int? SuffixId { get; set; }
        public int? MovementId { get; set; }
        public SecurityLevel SecurityLevel { get; set; }

        public DateTime? DOB { get; set; }
        public bool? ActualDOB { get; set; }
        public DateTime? DeceasedDate { get; set; }
        public bool? ActualDeceasedDate { get; set; }

        public string Height { get; set; }
        public string Weight { get; set; }
        public string DistinguishableMarks { get; set; }

        public string SSN { get; set; }

        public LicenseType? LicenseType { get; set; }
        public string DriversLicenseNumber { get; set; }
        public int? DriversLicenseStateId { get; set; }

        public MaritialStatus? MaritialStatus { get; set; }
        public Gender? Gender { get; set; }
        public int? HairColorId { get; set; }
        public int? HairPatternId { get; set; }
        public int? EyeColorId { get; set; }
        public int? RaceId { get; set; }

        public Movement Movement { get; set; }
        public ICollection<OnlineAlias> OnlineAlias { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<Website> Websites { get; set; }

        public ICollection<PersonLogEntry> LogEntries { get; set; }
        public ICollection<PersonAddress> PersonAddresses { get; set; }
        public ICollection<PersonAlias> PersonAliases { get; set; }
        public ICollection<Correspondence> Correspondence { get; set; }
        public ICollection<Publication> Publications { get; set; }
        public ICollection<Chapter> Chapters { get; set; }
        public ICollection<Organization> Organizations { get; set; }
        public ICollection<MediaImage> MediaImages { get; set; }
        public ICollection<AudioVideo> AudioVideos { get; set; }

    }

    public class OnlineAlias: BaseEntity
    {
        //todo: better name
        public string ScreenName { get; set; }
        //todo: better name
        public string UsedAt { get; set; }
        public DateTime? FirstUsedDate { get; set; }
        public DateTime? LastUsedDate { get; set; }
    }

    public class PersonAlias : Alias
    {
    }

    public class PersonAddress : Address
    {
    }

    public class Race
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class EyeColor
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class HairPattern
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class HairColor
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum Gender
    {
        Female = 1,
        Male = 2,
        Unknown = 3
    }

    public enum MaritialStatus
    {
        Single = 1,
        Married = 2,
        Divorced = 3,
        Widowed = 4,
        Separated = 11,
        LongTermRel = 21
    }

    public enum LicenseType
    {
        Operator = 1,
        Restricted = 2,
        Chauffeur = 3,
        IDCardOnly = 4
    }

    public class PersonLogEntry : LogEntry
    {
    }
}