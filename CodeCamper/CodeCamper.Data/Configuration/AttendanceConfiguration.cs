﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeCamper.Model;

namespace CodeCamper.Data.Configuration
{
    public class AttendanceConfiguration : EntityTypeConfiguration<Attendance>
    {
        public AttendanceConfiguration()
        {
            HasKey(a => new {a.SessionId, a.PersonId});

            // Attendance has 1 session. Session has many attendances
            HasRequired(a => a.Session)
                .WithMany(s => s.AttendanceList)
                .HasForeignKey(s=>s.SessionId)
                .WillCascadeOnDelete(false);

            // Attendance has 1 person. Person has many attendances
            HasRequired(a => a.Person)
                .WithMany(p => p.AttendanceList)
                .HasForeignKey(a => a.PersonId)
                .WillCascadeOnDelete(false);
        }
    }
}
