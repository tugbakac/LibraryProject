using LibraryProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Entities.concrete
{
    public class Phone : IEntity
    {
        public int ID { get; set; }
        public int MemberID { get; set; }
        public string NameSurname { get; set; }
        public string Proximity { get; set; }
        public string PhoneNo { get; set; }
        public string Description { get; set; }
        public virtual Member Member { get; set; }
    }
}
