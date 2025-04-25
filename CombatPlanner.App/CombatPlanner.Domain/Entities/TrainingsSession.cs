using System.ComponentModel.DataAnnotations;

namespace CombatPlanner.Domain.Entities
{
    public class TrainingsSession
    {
        [Key]
        public Guid SessionId { get; set; }
        public Guid PlanId { get; set; }

        public string Type { get; set; } = string.Empty; // e.g., "Strength", "Cardio", etc.
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public TrainingsPlan Plan { get; set; }
    }
}