using LibraryProject.Entities.concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Mapping
{
    public class WriterMap:EntityTypeConfiguration<Writer>
    {
        public WriterMap()
        {
            this.HasKey(a => a.ID);
            this.Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.Name).HasMaxLength(30);
            this.Property(a => a.Surname).HasMaxLength(30);
            this.Property(a => a.DateOfPlace).HasMaxLength(30);
            this.Property(a => a.Description).HasMaxLength(200);

            this.ToTable("Writers");
            this.Property(a => a.ID).HasColumnName("ID");
            this.Property(a => a.Name).HasColumnName("Name");
            this.Property(a => a.Surname).HasColumnName("Surname");
            this.Property(a => a.DateOfBirth).HasColumnName("DateOfBirth");
            this.Property(a => a.DateOfPlace).HasColumnName("DateOfPlace");
            this.Property(a => a.Description).HasColumnName("Description");
        }
    }
}
