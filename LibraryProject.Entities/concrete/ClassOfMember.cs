using LibraryProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Entities.concrete
{
    public class ClassOfMember : IEntity
    {
        public int ID { get; set; }
        public string TypeOfSchool { get; set; }
        public string MemberClass { get; set; }
        public string Branch { get; set; }
        public string Division { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Member> Members { get; set; }
    }
}
