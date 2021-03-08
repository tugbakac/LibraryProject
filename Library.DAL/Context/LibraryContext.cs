using Library.DAL.Mapping;
using LibraryProject.Entities.concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Context
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Barcode> Barcodes { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Lending> Lendings { get; set; }
        public DbSet<Definition> Definitions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new BarcodeMap());
            modelBuilder.Configurations.Add(new WriterMap());
            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new ClassMap());
            modelBuilder.Configurations.Add(new PhoneMap());
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new LendingMap());
            modelBuilder.Configurations.Add(new DefinitionMap());

            modelBuilder.Entity<Book>().
                HasRequired(a => a.Writer).
                WithMany(a => a.Books).
                HasForeignKey(a => a.WriterID);

            modelBuilder.Entity<Barcode>().
                HasRequired(a => a.Books).
                WithMany(a => a.Barcodes).
                HasForeignKey(a => a.BookID);

            modelBuilder.Entity<Lending>().
                HasRequired(a => a.Book).
                WithMany(a => a.Lendings).
                HasForeignKey(a => a.BookID);

            modelBuilder.Entity<Member>().
                HasRequired(a => a.ClassOfMember).
                WithMany(a => a.Members).
                HasForeignKey(a => a.ClassID);

            modelBuilder.Entity<Phone>().
                HasRequired(a => a.Member).
                WithMany(a => a.Phones).
                HasForeignKey(a => a.MemberID);

            modelBuilder.Entity<Address>().
               HasRequired(a => a.Member).
               WithMany(a => a.Addresses).
               HasForeignKey(a => a.MemberID);

            modelBuilder.Entity<Lending>().
                HasRequired(a => a.Member).
                WithMany(a => a.Lendings).
                HasForeignKey(a => a.MemberID);


        }
    }

}
