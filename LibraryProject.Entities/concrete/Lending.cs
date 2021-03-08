using LibraryProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Entities.concrete
{
    public class Lending : IEntity
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public int MemberID { get; set; }
        public DateTime DateOfIssue { get; set; }
        public int IssueTime { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int Evaluation { get; set; }
        public int EvaluationTime { get; set; }
        public int EvaluationAuthority { get; set; }
        public string Description { get; set; }
        public virtual Member Member { get; set; }
        public virtual Book Book { get; set; }
    }
}
