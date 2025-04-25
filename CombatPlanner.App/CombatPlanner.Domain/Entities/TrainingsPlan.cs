using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatPlanner.Domain.Entities.Identity;

namespace CombatPlanner.Domain.Entities
{
    public class TrainingsPlan
    {
        [Key]
        public Guid PlanId { get; set; }
        public Guid UserId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ApplicationUser User { get; set; }
        public ICollection<TrainingsSession> TrainingsSessions { get; set; } = new List<TrainingsSession>();
    }
}
