using System.ComponentModel.DataAnnotations;
using CombatPlanner.Domain.Entities.Identity;

namespace CombatPlanner.Domain.Entities
{
    public class WeightEntry
    {
        [Key]
        public Guid EntryId { get; set; }
        public Guid UserId { get; set; }

        public double WeightKg { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ApplicationUser User { get; set; } = null!;
    }
}
