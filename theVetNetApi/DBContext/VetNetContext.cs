
using Microsoft.EntityFrameworkCore;
using theVetNetApi.Models;

namespace theVetNetApi.DBContext
{
    public class VetNetContext : DbContext
    {
        public VetNetContext(DbContextOptions<VetNetContext> options) 
            : base(options) 
        {
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) 
        {
            //modelBuilder.Entity<>();
        }

        public DbSet<AdvertExtra> AdvertExtras {get; set;}
        public DbSet<ApplyOffer> ApplyOffers {get; set;}
        public DbSet<BlockedUser> BlockedUsers {get; set;}
        public DbSet<BusinessPhoto> BusinessPhotos {get; set;}
        public DbSet<BusinessProfile> BusinessProfiles {get; set;}
        public DbSet<CompanyPhoto> CompanyPhotos {get; set;}
        public DbSet<CompanyProfile> CompanyProfiles {get; set;}
        public DbSet<Education> Educations {get; set;}
        public DbSet<Employer> Employers {get; set;}
        public DbSet<Experience> Experiences {get; set;}
        public DbSet<ExtraFeature> ExtraFeatures {get; set;}
        public DbSet<GeneralInfo> GeneralInfos {get; set;}
        public DbSet<JobAdvert> JobAdverts {get; set;}
        public DbSet<Message> Messages {get; set;}
        public DbSet<MessageAttachment> MessageAttachments {get; set;}
        public DbSet<PrivacySetting> PrivacySettings {get; set;}
        public DbSet<Referee> Referees {get; set;}
        public DbSet<Registration> Registrations {get; set;}
        public DbSet<User> Users {get; set;}
        public DbSet<UserLog> UserLogs {get; set;}


    }//end class
}//end namespace