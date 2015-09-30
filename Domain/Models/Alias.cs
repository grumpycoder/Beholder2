using Domain.Models.Enums;

namespace Domain.Models
{
    public class Alias: BaseEntity
    {
        public string Name { get; set; }
        public PrimaryStatus PrimaryStatus { get; set; }
    }
}