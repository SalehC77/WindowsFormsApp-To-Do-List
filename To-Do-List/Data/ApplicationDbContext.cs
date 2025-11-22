using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_Do_List.Entities;

namespace To_Do_List.Data
{
    internal class ApplicationDbContext : DbContext
    {
        // Move Database.SetInitializer to a static constructor to avoid invalid member declaration errors.
        static ApplicationDbContext()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, To_Do_List.Migrations.Configuration>());
        }

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<DisabilityType> DisabilityTypes { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Donor> Donors { get; set; }
        public virtual DbSet<Donation> Donations { get; set; }
        public virtual DbSet<StaffType> StaffTypes { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<ActivityStudent> ActivityStudents { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
