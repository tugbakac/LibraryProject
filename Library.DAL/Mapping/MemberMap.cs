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
    public class MemberMap : EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            this.HasKey(a => a.ID);
            this.Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.TCIdNo).HasMaxLength(11);
            this.Property(a => a.Barcode).HasMaxLength(12);
            this.Property(a => a.Name).HasMaxLength(30);
            this.Property(a => a.Surname).HasMaxLength(30);
            this.Property(a => a.ForeignLanguage).HasMaxLength(25);
            this.Property(a => a.Description).HasMaxLength(200);

            this.ToTable("Members");
            this.Property(a => a.ID).HasColumnName("ID");
            this.Property(a => a.TCIdNo).HasColumnName("TCIdNo");
            this.Property(a => a.TypeOfSchool).HasColumnName("TypeOfSchool");
            this.Property(a => a.NumberOfSchool).HasColumnName("NumberOfSchool");
            this.Property(a => a.Barcode).HasColumnName("Barcode");
            this.Property(a => a.Name).HasColumnName("Name");
            this.Property(a => a.Surname).HasColumnName("Surname");
            this.Property(a => a.ClassID).HasColumnName("ClassID");
            this.Property(a => a.ForeignLanguage).HasColumnName("ForeignLanguage");
            this.Property(a => a.DateOfRecord).HasColumnName("DateOfRecord");
            this.Property(a => a.Description).HasColumnName("Description");
        }
    }
}
