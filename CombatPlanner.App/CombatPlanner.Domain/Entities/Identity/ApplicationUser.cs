using Microsoft.AspNetCore.Identity;

namespace CombatPlanner.Domain.Entities.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<TrainingsPlan> TrainingPlans { get; set; } = new List<TrainingsPlan>();
        public ICollection<DailyNote> DailyNotes { get; set; } = new List<DailyNote>();
        public ICollection<WeightEntry> WeightEntries { get; set; } = new List<WeightEntry>();
        public ICollection<Goal> Goals { get; set; } = new List<Goal>();
    }
}
