using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Service.Models.Mapping
{
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Books");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
