using Domain.Models.Enums;

namespace Domain.Models
{
    public class Address: BaseEntity
    {
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public int? StateId { get; set; }
        public string ZipCode { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }

        public PrimaryStatus PrimaryStatus { get; set; }
    }
}