using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoApp.Domain;

namespace ToDoApp.DAL
{
    public class UserDetailMapping : IEntityTypeConfiguration<UserDetail>
    {
        public void Configure(EntityTypeBuilder<UserDetail> builder)
        {
            builder.ToTable("UserDetail");
            builder.HasKey(ud => ud.UserDetailID);

            builder.Property(ud => ud.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(ud => ud.LastName).IsRequired().HasMaxLength(50);
            builder.Property(ud => ud.BirthDate).IsRequired();

            builder.HasMany(ud => ud.Addresses)
                .WithOne(a => a.UserDetail)
                .HasForeignKey(ud => ud.UserDetailID);

        }
    }
}
