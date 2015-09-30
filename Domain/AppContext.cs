using System;
using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Diagnostics;
using Domain.Models;
using Domain.Models.Enums;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Domain
{
    public class AppContext : IdentityDbContext<ApplicationUser>
    {
        public AppContext() : base("name=DefaultConnection")
        {
            Database.Log = msg => Debug.WriteLine(msg);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Properties<string>().Configure(c => c.HasColumnType("varchar"));
            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));

            modelBuilder.Entity<ApplicationUser>().ToTable("Users", "Security");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles", "Security");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims", "Security");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins", "Security");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles", "Security");

            modelBuilder.Entity<Person>().ToTable("Persons").HasMany(t => t.Websites);
            modelBuilder.Entity<Person>().HasMany(t => t.Correspondence);
            modelBuilder.Entity<Person>().HasMany(t => t.Publications);
            modelBuilder.Entity<Person>().HasMany(t => t.MediaImages);
            modelBuilder.Entity<Person>().HasMany(t => t.AudioVideos);
            modelBuilder.Entity<Person>().HasMany(t => t.OnlineAlias);
            modelBuilder.Entity<Person>().HasMany(t => t.Websites);

            modelBuilder.Entity<Chapter>().ToTable("Chapters");
            modelBuilder.Entity<Chapter>().HasMany(t => t.Websites);
            modelBuilder.Entity<Chapter>().HasMany(t => t.Persons);
            modelBuilder.Entity<Chapter>().HasMany(t => t.Correspondence);
            modelBuilder.Entity<Chapter>().HasMany(t => t.Publications);
            modelBuilder.Entity<Chapter>().HasMany(t => t.MediaImages);
            modelBuilder.Entity<Chapter>().HasMany(t => t.AudioVideos);
            modelBuilder.Entity<Chapter>().HasMany(t => t.Subscriptions);

            modelBuilder.Entity<Organization>().ToTable("Organizations");
            modelBuilder.Entity<Organization>()
                .HasMany(t => t.Persons)
                .WithMany(o => o.Organizations)
                .Map(x => x.ToTable("OrganizationPersons").MapLeftKey("OrganizationId").MapRightKey("PersonId"));
            modelBuilder.Entity<Organization>().HasMany(t => t.Websites);
            modelBuilder.Entity<Organization>().HasMany(t => t.Chapters);
            modelBuilder.Entity<Organization>().HasMany(t => t.Correspondence);
            modelBuilder.Entity<Organization>().HasMany(t => t.Publications);
            modelBuilder.Entity<Organization>().HasMany(t => t.Subscriptions);
            modelBuilder.Entity<Organization>().HasMany(t => t.AudioVideos);
            modelBuilder.Entity<Organization>().HasMany(t => t.MediaImages);

            modelBuilder.Entity<Event>().ToTable("Events");
            modelBuilder.Entity<Event>().HasMany(t => t.Organizations);
            modelBuilder.Entity<Event>().HasMany(t => t.Chapters);
            modelBuilder.Entity<Event>().HasMany(t => t.Persons);
            modelBuilder.Entity<Event>().HasMany(t => t.Publications);
            modelBuilder.Entity<Event>().HasMany(t => t.MediaImages);
            modelBuilder.Entity<Event>().HasMany(t => t.AudioVideos);
            modelBuilder.Entity<Event>().HasMany(t => t.Correspondences);
            //todo: need seperate table for relationship
            modelBuilder.Entity<Event>().HasMany(t => t.Events);

            modelBuilder.Entity<Website>().ToTable("Websites");
            modelBuilder.Entity<Website>().HasMany(t => t.Persons);
            modelBuilder.Entity<Website>().HasMany(t => t.Publications);
            modelBuilder.Entity<Website>().HasMany(t => t.Correspondences);

            modelBuilder.Entity<Correspondence>().ToTable("Correspondences");

            modelBuilder.Entity<Publication>().ToTable("Publication");
            modelBuilder.Entity<Publication>().HasMany(t => t.Correspondence);

            modelBuilder.Entity<Subscription>().ToTable("Subscription").HasMany(t => t.Publications);
            
            modelBuilder.Entity<Activity>().ToTable("Activity")
                .Map<ChapterActivity>(m => m.Requires("Type").HasValue("Chapter"))
                .Map<OrganizationActivity>(m => m.Requires("Type").HasValue("Organization"));

            modelBuilder.Entity<Address>()
                .Map<ChapterAddress>(m => m.Requires("Type").HasValue("Chapter"))
                .Map<PersonAddress>(m => m.Requires("Type").HasValue("Person"))
                .Map<EventAddress>(m => m.Requires("Type").HasValue("Event"));

            modelBuilder.Entity<Alias>()
                .Map<ChapterAlias>(m => m.Requires("Type").HasValue("Chapter"))
                .Map<PersonAlias>(m => m.Requires("Type").HasValue("Person"))
                .Map<OrganizationAlias>(m => m.Requires("Type").HasValue("Organization"));


            modelBuilder.Entity<LogEntry>()
                .Map<ChapterLogEntry>(m => m.Requires("Type").HasValue("Chapter"))
                .Map<OrganizationLogEntry>(m => m.Requires("Type").HasValue("Organization"))
                .Map<MediaImageLogEntry>(m => m.Requires("Type").HasValue("MediaImage"))
                .Map<PersonLogEntry>(m => m.Requires("Type").HasValue("Person"))
                .Map<CorrespondenceLogEntry>(m => m.Requires("Type").HasValue("Correspondence"))
                .Map<PublicationLogEntry>(m => m.Requires("Type").HasValue("Publication"))
                .Map<AudioVideoLogEntry>(m => m.Requires("Type").HasValue("AudioVideo"))
                .Map<SubscriptionLogEntry>(m => m.Requires("Type").HasValue("Subscription"))
                .Map<WebsiteLogEntry>(m => m.Requires("Type").HasValue("Website")); ;


        }

        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Website> Websites { get; set; }
        public DbSet<Correspondence> Correspondences { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<MediaImage> MediaImages { get; set; }
        public DbSet<AudioVideo> AudioVideos { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Alias> Aliases { get; set; }
        public DbSet<LogEntry> LogEntries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Movement> Movements { get; set; }

        public DbSet<HairColor> HairColors { get; set; }
        public DbSet<HairPattern> HairPatterns { get; set; }
        public DbSet<EyeColor> EyeColors { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Suffix> Suffixes { get; set; }
        public DbSet<Prefix> Prefixes { get; set; }

    }
}

