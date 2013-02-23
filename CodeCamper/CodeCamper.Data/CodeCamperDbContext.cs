using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeCamper.Data.Configuration;
using CodeCamper.Data.SampleData;
using CodeCamper.Model;

namespace CodeCamper.Data
{
    public class CodeCamperDbContext : DbContext
    {
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<Track> Tracks { get; set; } 
    

        public CodeCamperDbContext() :
            base("CodeCamper")
        {
            
        }

        static CodeCamperDbContext()
        {
            Database.SetInitializer(new CodeCamperDatabaseInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new SessionConfiguration());
            modelBuilder.Configurations.Add(new AttendanceConfiguration());
        }
    }
}
