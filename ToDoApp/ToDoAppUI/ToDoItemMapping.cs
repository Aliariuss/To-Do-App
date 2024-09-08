
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoApp.Domain;

namespace ToDoApp.DAL
{
    public class ToDoItemMapping : IEntityTypeConfiguration<ToDoItem>
    {
        public void Configure(EntityTypeBuilder<ToDoItem> builder)
        {
            builder.ToTable(nameof(ToDoItem));
            builder.HasKey(td=>td.ToDoItemID);

            builder.Property(t => t.ToDoItemID)
                   .IsRequired()
                   .ValueGeneratedOnAdd(); 

            builder.Property(t => t.UserID)
                   .IsRequired();

            builder.Property(t => t.Title)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(t => t.Description)
                   .HasMaxLength(500);

            builder.Property(t => t.IsCompleted)
                   .IsRequired();

            builder.Property(t => t.DueDate)
                   .IsRequired();
                        
            builder.HasOne(t => t.User)
                   .WithMany(u => u.ToDoItems)
                   .HasForeignKey(t => t.UserID)
                   .OnDelete(DeleteBehavior.Cascade); 

        }
    }
}
