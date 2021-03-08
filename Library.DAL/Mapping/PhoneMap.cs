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
    public class PhoneMap : EntityTypeConfiguration<Phone>
    {
        public PhoneMap()
        {
            this.HasKey(a => a.ID);
            this.Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.NameSurname).HasMaxLength(61);
            this.Property(a => a.Proximity).HasMaxLength(15);
            this.Property(a => a.PhoneNo).HasMaxLength(15);
            this.Property(a => a.Description).HasMaxLength(200);

            this.ToTable("Phones");
            this.Property(a=>a.ID).HasColumnName("ID");
            this.Property(a=>a.MemberID).HasColumnName("MemberID");
            this.Property(a=>a.NameSurname).HasColumnName("NameSurname");
            this.Property(a=>a.Proximity).HasColumnName("Proximity");
            this.Property(a=>a.PhoneNo).HasColumnName("PhoneNo");
            this.Property(a=>a.Description).HasColumnName("Description");

        }
    }
}
