using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Service.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserID);

            // Properties
            this.Property(t => t.UserName)
                .HasMaxLength(200);

            this.Property(t => t.Password)
                .HasMaxLength(200);

            this.Property(t => t.Discribe)
                .HasMaxLength(800);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Discribe).HasColumnName("Discribe");
            this.Property(t => t.SubmitTime).HasColumnName("SubmitTime");
        }
    }
}
