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
    public class LendingMap : EntityTypeConfiguration<Lending>
    {
        public LendingMap()
        {
            this.HasKey(a => a.ID);
            this.Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.Description).HasMaxLength(200);

            this.ToTable("Lendings");
            this.Property(a => a.ID).HasColumnName("ID");
            this.Property(a => a.BookID).HasColumnName("BookID");
            this.Property(a => a.MemberID).HasColumnName("MemberID");
            this.Property(a => a.DateOfIssue).HasColumnName("DateOfIssue");
            this.Property(a => a.IssueTime).HasColumnName("IssueTime");
            this.Property(a => a.DeliveryDate).HasColumnName("DeliveryDate");
            this.Property(a => a.Evaluation).HasColumnName("Evaluation");
            this.Property(a => a.EvaluationTime).HasColumnName("EvaluationTime");
            this.Property(a => a.EvaluationAuthority).HasColumnName("EvaluationAuthority");
            this.Property(a => a.Description).HasColumnName("Description");

        }
    }
}
