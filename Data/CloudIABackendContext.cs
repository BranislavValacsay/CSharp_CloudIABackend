using Microsoft.EntityFrameworkCore;
using CloudIABackend.Models;
//using CloudIABackend.Models.JobOfferClasses;
using JobOfferTechStack = CloudIABackend.Models.JobOfferTechStack;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CloudIABackend.Data
{
    public class NetRunnersBackendContext : IdentityDbContext<
        AppUser,
        AppRole,
        int,
        IdentityUserClaim<int>,
        AppUserRole,
        IdentityUserLogin<int>,
        IdentityRoleClaim<int>,
        IdentityUserToken<int>
        >
    {
        public NetRunnersBackendContext (DbContextOptions<NetRunnersBackendContext> options) : base(options)
        {
        }

        public DbSet<CloudIABackend.Models.JobOffer> JobOffers { get; set; }
        public DbSet<CloudIABackend.Models.Contact> Contact { get; set; }
        public DbSet<CloudIABackend.Models.CandidateApplications> CandidateApplications { get; set; }
        public DbSet<CloudIABackend.Models.Visitors> Visitors { get; set; }
        public DbSet<CloudIABackend.Models.ENUM_JobType> ENUM_JobType { get; set; }
        public DbSet<CloudIABackend.Models.ENUM_JobState> ENUM_JobState { get; set; }
        public DbSet<CloudIABackend.Models.ENUM_JobCity> ENUM_JobCity { get; set; }
        public DbSet<CloudIABackend.Models.ENUM_JobTechStack> ENUM_JobTechStack { get; set; }
        public DbSet<CloudIABackend.Models.ENUM_JobSource> ENUM_SourceCompany { get; set; }
        public DbSet<CloudIABackend.Models.ENUM_JobLanguage> ENUM_Language { get; set; }
        public DbSet<CloudIABackend.Models.ENUM_JobTechStackCategory> ENUM_JobTechStackCategory { get; set; }
        public DbSet<CloudIABackend.Models.ENUM_JobTechStack> Techstack { get; set; }
        public DbSet<CloudIABackend.Models.JobOfferTechStack> JobOfferTechstack { get; set; } // table that connects jobID and TechStackId, defined below in builder


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>()
            .HasMany(ur => ur.UserRoles)
            .WithOne(u => u.User)
            .HasForeignKey(Ur => Ur.UserId)
            .IsRequired();

            builder.Entity<AppRole>()
            .HasMany(ur => ur.UserRoles)
            .WithOne(u => u.Roles)
            .HasForeignKey(Ur => Ur.RoleId)
            .IsRequired();

            builder.Entity<JobOffer>().HasKey(key => key.Guid);

            builder.Entity<JobOfferTechStack>().HasKey(sc => new { sc.JobGuid, sc.TechStackSkillId });

            builder.Entity<JobOfferTechStack>()
            .HasOne<JobOffer>(sc => sc.JobOffer)
            .WithMany(s => s.ClassTechStack)
            .HasPrincipalKey(p => p.Guid)
            .HasForeignKey(s => s.JobGuid);


            builder.Entity<JobOfferTechStack>()
            .HasOne<ENUM_JobTechStack>(sc => sc.TechStack)
            .WithMany(s => s.ClassJobOffer)
            .HasForeignKey(s => s.TechStackSkillId);

            builder.Entity<ENUM_JobTechStack>()
            .HasOne(p => p.Category)
            .WithMany(p => p.skillChips)
            .HasForeignKey(p => p.CategoryId);
        }
    }
}