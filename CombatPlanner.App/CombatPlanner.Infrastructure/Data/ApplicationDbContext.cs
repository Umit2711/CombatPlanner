using CombatPlanner.Domain.Entities;
using CombatPlanner.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CombatPlanner.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TrainingsPlan> TrainingsPlans => Set<TrainingsPlan>();
        public DbSet<TrainingsSession> TrainingsSessions => Set<TrainingsSession>();
        public DbSet<DailyNote> DailyNotes => Set<DailyNote>();
        public DbSet<WeightEntry> WeightEntries => Set<WeightEntry>();
        public DbSet<Goal> Goals => Set<Goal>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // name tables
            builder.Entity<ApplicationUser>().ToTable("Users");
            builder.Entity<IdentityRole<Guid>>().ToTable("Roles");
            builder.Entity<IdentityUserRole<Guid>>().ToTable("UserRoles");
            builder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaims");
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogins");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens");
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims");

            builder.Entity<TrainingsPlan>()
                .HasOne(p => p.User)
                .WithMany(u => u.TrainingPlans)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<TrainingsSession>()
                .HasOne(s => s.Plan)
                .WithMany(p => p.TrainingsSessions)
                .HasForeignKey(s => s.PlanId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<DailyNote>()
                .HasOne(n => n.User)
                .WithMany(u => u.DailyNotes)
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<WeightEntry>()
                .HasOne(w => w.User)
                .WithMany(u => u.WeightEntries)
                .HasForeignKey(w => w.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Goal>()
                .HasOne(g => g.User)
                .WithMany(u => u.Goals)
                .HasForeignKey(g => g.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
