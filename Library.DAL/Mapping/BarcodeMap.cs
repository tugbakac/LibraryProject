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
    public class BarcodeMap : EntityTypeConfiguration<Barcode>
    {
        public BarcodeMap()
        {
            this.HasKey(a => a.ID);
            this.Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.BookBarcode).HasMaxLength(12);
            this.Property(a => a.LivingRoom).HasMaxLength(30);
            this.Property(a => a.Cabinet).HasMaxLength(30);
            this.Property(a => a.Shelf).HasMaxLength(30);
            this.Property(a => a.DeskQueue).HasMaxLength(10);
            this.Property(a => a.Description).HasMaxLength(200);

            this.ToTable("Barcodes");
            this.Property(a => a.ID).HasColumnName("ID");
            this.Property(a => a.BookBarcode).HasColumnName("Barcode");
            this.Property(a => a.Condition).HasColumnName("Condition");
            this.Property(a => a.BookID).HasColumnName("BookID");
            this.Property(a => a.LivingRoom).HasColumnName("LivingRoom");
            this.Property(a => a.Cabinet).HasColumnName("Cabinet");
            this.Property(a => a.Shelf).HasColumnName("Shelf");
            this.Property(a => a.DeskQueue).HasColumnName("DeskQueue");
            this.Property(a => a.Description).HasColumnName("Description");

        }
    }
}
