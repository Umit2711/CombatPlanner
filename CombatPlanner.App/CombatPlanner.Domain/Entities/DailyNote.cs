using System.ComponentModel.DataAnnotations;
using CombatPlanner.Domain.Entities.Identity;

namespace CombatPlanner.Domain.Entities
{
    public class DailyNote
    {
        [Key]
        public Guid NoteId { get; set; }
        public Guid UserId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string Note { get; set; } = string.Empty;

        public ApplicationUser User { get; set; }
    }
}
