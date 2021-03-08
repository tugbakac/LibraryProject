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
    public class ClassMap : EntityTypeConfiguration<ClassOfMember>
    {
        public ClassMap()
        {
            this.HasKey(a => a.ID);
            this.Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.TypeOfSchool).HasMaxLength(30);
            this.Property(a => a.MemberClass).HasMaxLength(10);
            this.Property(a => a.Branch).HasMaxLength(10);
            this.Property(a => a.Division).HasMaxLength(30);
            this.Property(a => a.Description).HasMaxLength(200);

            this.ToTable("Classes");
            this.Property(a => a.ID).HasColumnName("ID");
            this.Property(a => a.TypeOfSchool).HasColumnName("TypeOfSchool");
            this.Property(a => a.MemberClass).HasColumnName("MemberClass");
            this.Property(a => a.Branch).HasColumnName("Branch");
            this.Property(a => a.Division).HasColumnName("Division");
            this.Property(a => a.Description).HasColumnName("Description");
        }
    }
}
