using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bll.Models.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Phone)
                .IsRequired()
                .HasMaxLength(11);

            // Table & Column Mappings
            this.ToTable("Customer", "WebApiDemo");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Phone).HasColumnName("Phone");
        }
    }
}
