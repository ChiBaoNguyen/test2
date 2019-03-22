using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_MVC.Root.Model.Mapping
{
    class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.IDCategory);

            this.Property(t => t.CategoryName)
                .HasMaxLength(50).IsRequired();

            this.Property(t => t.CategoryCreatedDate)
                .HasColumnType("date");

            this.Property(t => t.CategoryIsActive)
                .HasMaxLength(1)
                .IsFixedLength()
                .IsUnicode(false);
            // Table & Column Mappings
            this.ToTable("Category");
            this.Property(t => t.IDCategory).HasColumnName("IDCategory");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.CategoryCreatedDate).HasColumnName("CategoryCreatedDate");
            this.Property(t => t.CategoryIsActive).HasColumnName("CategoryIsActive");
        }
    }
}
