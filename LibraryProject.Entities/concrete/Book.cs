using LibraryProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Entities.concrete
{
    public class Book : IEntity
    {
        public int ID { get; set; }
        public bool State { get; set; }
        public bool CanBorrowed { get; set; }
        public int BarcodeID { get; set; }
        public string BookCode { get; set; }
        public string ISBN { get; set; }
        public string BookName { get; set; }
        public int WriterID { get; set; }
        public int TypeID { get; set; }
        public string Publisher { get; set; }
        public int YearOfPrinting { get; set; }
        public int NumberOfPrinting { get; set; }
        public int NumberOfVolumes { get; set; }
        public int NumberOfPage { get; set; }
        public string PlaceOfPublication { get; set; }
        public string FixtureNo { get; set; }
        public string Description { get; set; }
        public virtual Writer Writer { get; set; }
        public virtual Definition Definitions { get; set; }
        public virtual ICollection<Barcode> Barcodes { get; set; }
        public virtual ICollection<Lending> Lendings { get; set; }
    }
}
