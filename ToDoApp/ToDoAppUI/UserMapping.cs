using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoApp.Domain;

namespace ToDoApp.DAL
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(a => a.UserID);
            builder.Property(a => a.UserName).IsRequired().HasMaxLength(20);
            builder.Property(a => a.Email).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Password).IsRequired().HasMaxLength(20);
            builder.Property(a => a.Phone).IsRequired().HasMaxLength(12);

            builder.HasOne(a => a.Gender)
                .WithMany(a => a.Users)
                .HasForeignKey(a => a.GenderID);

            builder.HasOne(a => a.UserDetail)
                .WithOne(a => a.User)
                .HasForeignKey<UserDetail>(ud => ud.UserID);

        }
    }
}
