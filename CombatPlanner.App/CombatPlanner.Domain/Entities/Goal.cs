using System.ComponentModel.DataAnnotations;
using CombatPlanner.Domain.Entities.Identity;

namespace CombatPlanner.Domain.Entities
{
    public class Goal
    {
        [Key]
        public Guid GoalId { get; set; }
        public Guid UserId { get; set; }

        public double TargetWeight { get; set; }
        public int TargetSessionsPerWeek { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;

        public ApplicationUser User { get; set; }
    }
}
