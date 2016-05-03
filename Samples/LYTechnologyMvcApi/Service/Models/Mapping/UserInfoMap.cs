using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Service.Models.Mapping
{
    public class UserInfoMap : EntityTypeConfiguration<UserInfo>
    {
        public UserInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UserName)
                .HasMaxLength(30);

            this.Property(t => t.Remark)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UserInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Birthday).HasColumnName("Birthday");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
