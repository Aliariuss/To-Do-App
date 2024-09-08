using Microsoft.EntityFrameworkCore;
using ToDoApp.Domain;


namespace ToDoApp.DAL.AppDBContext
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MSI;Initial Catalog=ToDoAppDb;User ID=TestUser;Password=admin123;TrustServerCertificate=true");
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<ToDoItem> ToDoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new UserDetailMapping());
            modelBuilder.ApplyConfiguration(new ToDoItemMapping());
            modelBuilder.ApplyConfiguration(new GenderMapping());
            modelBuilder.ApplyConfiguration(new AddressMapping());


            modelBuilder.Entity<Gender>().HasData
            (
                new Gender
                {
                    GenderID = 1,
                    GenderName = "Kadın"
                },
                new Gender
                {
                    GenderID = 2,
                    GenderName = "Erkek"
                }
            );
            modelBuilder.Entity<User>().HasData
            (
                new User
                {
                    UserID = 1,
                    UserName = "Default",
                    Password = "Default",
                    GenderID = 1,
                    Email = "Default@example.com",
                    Phone = "555-444-333"
                }
            );
            modelBuilder.Entity<UserDetail>().HasData
            (
                new UserDetail
                {
                    UserID = 1,
                    UserDetailID = 1,
                    BirthDate = DateTime.Now,
                    FirstName = "DefaultName",
                    LastName = "DefaultLastName"
                }
            );
            modelBuilder.Entity<Address>().HasData
            (
                new Address
                {
                    AddressID = 1,
                    City = "DefaultCity",
                    Country = "DefaultCountry",
                    PostalCode = "123-456",
                    Region = "DefaultRegion",
                    UserDetailID = 1
                }
            );

        }

    }


}
