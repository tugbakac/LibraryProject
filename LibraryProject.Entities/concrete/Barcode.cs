using LibraryProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Entities.concrete
{
    public class Barcode : IEntity
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public string BookBarcode { get; set; }
        public int Condition { get; set; }
        public string LivingRoom { get; set; }
        public string Cabinet { get; set; }
        public string Shelf { get; set; }
        public string DeskQueue { get; set; }
        public string Description { get; set; }
        public virtual Book Books { get; set; }
    }
}
