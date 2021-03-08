
using LibraryProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Entities.concrete
{
    public class Address : IEntity
    {
        public int ID { get; set; }
        public int MemberID { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Neighborhood { get; set; }
        public string Addresss { get; set; }
        public string Description { get; set; }
        public virtual Member Member { get; set; }
    }
}
