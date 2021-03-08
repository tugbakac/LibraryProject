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
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            this.HasKey(a => a.ID);
            this.Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.City).HasMaxLength(30);
            this.Property(a => a.District).HasMaxLength(30);
            this.Property(a => a.Neighborhood).HasMaxLength(30);
            this.Property(a => a.Addresss).HasMaxLength(100);
            this.Property(a => a.Description).HasMaxLength(200);

            this.ToTable("Addresses");
            this.Property(a => a.ID).HasColumnName("ID");
            this.Property(a => a.MemberID).HasColumnName("MemberID");
            this.Property(a => a.City).HasColumnName("City");
            this.Property(a => a.District).HasColumnName("District");
            this.Property(a => a.Neighborhood).HasColumnName("Neighborhood");
            this.Property(a => a.Addresss).HasColumnName("Addresss");
            this.Property(a => a.Description).HasColumnName("Description");

        }
    }
}
