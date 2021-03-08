using LibraryProject.Entities.concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Mapping
{
    public class DefinitionMap: EntityTypeConfiguration<Definition>
    {
        public DefinitionMap()
        {
            this.HasKey(a => a.ID);
            this.Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.DefinitionType).HasMaxLength(30);
            this.Property(a => a.Description).HasMaxLength(200);

            this.ToTable("Definitions");
            this.Property(a => a.ID).HasColumnName("ID");
            this.Property(a => a.DefinitionType).HasColumnName("DefinitionType");
            this.Property(a => a.Description).HasColumnName("Description");
        }
    }
}
