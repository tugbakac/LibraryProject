using LibraryProject.Entities.concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.DAL.Mapping
{
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            this.HasKey(a=>a.ID);
            this.Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.BookCode).HasMaxLength(12);
            this.Property(a => a.ISBN).HasMaxLength(20);
            this.Property(a => a.BookName).HasMaxLength(50);
            this.Property(a => a.Publisher).HasMaxLength(50);
            this.Property(a => a.PlaceOfPublication).HasMaxLength(30);
            this.Property(a => a.FixtureNo).HasMaxLength(20);
            this.Property(a => a.Description).HasMaxLength(200);

            this.ToTable("Books");
            this.Property(a => a.ID).HasColumnName("ID");
            this.Property(a => a.State).HasColumnName("State");
            this.Property(a => a.CanBorrowed).HasColumnName("CanBorrowed");
            this.Property(a => a.BarcodeID).HasColumnName("BarcodeID");
            this.Property(a => a.BookCode).HasColumnName("BookCode");
            this.Property(a => a.ISBN).HasColumnName("ISBN");
            this.Property(a => a.BookName).HasColumnName("BookName");
            this.Property(a => a.WriterID).HasColumnName("WriterID");
            this.Property(a => a.TypeID).HasColumnName("TypeID");
            this.Property(a => a.Publisher).HasColumnName("Publisher");
            this.Property(a => a.YearOfPrinting).HasColumnName("YearOfPrinting");
            this.Property(a => a.NumberOfPrinting).HasColumnName("NumberOfPrinting");
            this.Property(a => a.NumberOfVolumes).HasColumnName("NumberOfVolumes");
            this.Property(a => a.NumberOfPage).HasColumnName("NumberOfPage");
            this.Property(a => a.PlaceOfPublication).HasColumnName("PlaceOfPublication");
            this.Property(a => a.FixtureNo).HasColumnName("FixtureNo");
            this.Property(a => a.Description).HasColumnName("Description");
            
        }
    }
}
