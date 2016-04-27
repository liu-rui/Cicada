using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Service.Models.Mapping
{
    public class ClassMap : EntityTypeConfiguration<Class>
    {
        public ClassMap()
        {
            // Primary Key
            this.HasKey(t => t.ClassesId);

            // Properties
            this.Property(t => t.ClassesName)
                .HasMaxLength(100);

            this.Property(t => t.ClassesDescription)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Classes");
            this.Property(t => t.ClassesId).HasColumnName("ClassesId");
            this.Property(t => t.ClassesName).HasColumnName("ClassesName");
            this.Property(t => t.ClassesDescription).HasColumnName("ClassesDescription");
        }
    }
}
