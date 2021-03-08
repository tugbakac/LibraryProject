using LibraryProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Entities.concrete
{
    public class Member : IEntity
    {
        public int ID { get; set; }
        public bool State { get; set; }
        public string TCIdNo { get; set; }
        public string TypeOfSchool { get; set; }
        public int NumberOfSchool { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ClassID { get; set; }
        public string ForeignLanguage { get; set; }
        public DateTime DateOfRecord { get; set; }
        public string Description { get; set; }
        public virtual ClassOfMember ClassOfMember { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Lending> Lendings { get; set; }
    }
}
