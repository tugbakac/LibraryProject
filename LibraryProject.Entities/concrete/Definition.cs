using LibraryProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Entities.concrete
{
    public class Definition : IEntity
    {
        public int ID { get; set; }
        public string DefinitionType { get; set; }
        public string Description { get; set; }
    }
}
