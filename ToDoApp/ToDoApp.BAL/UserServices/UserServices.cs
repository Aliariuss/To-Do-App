using ToDoApp.Domain;
using Microsoft.EntityFrameworkCore;
using ToDoApp.DAL.AppDBContext;

namespace ToDoApp.BAL.UserServices
{
    public class UserServices
    {
        private readonly AppDbContext _context;

        public UserServices(AppDbContext context)
        {
            _context = context;
        }

        public void AddUser(User user, UserDetail userDetail, Address address)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (userDetail == null) throw new ArgumentNullException(nameof(userDetail));
            if (address == null) throw new ArgumentNullException(nameof(address));

            try
            {

                _context.Users.Add(user);
                _context.SaveChanges();


                userDetail.UserID = user.UserID;
                _context.UserDetails.Add(userDetail);
                _context.SaveChanges();


                address.UserDetailID = userDetail.UserDetailID;
                _context.Addresses.Add(address);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public User GetUserById(int userId)
        {
            return _context.Users
                          .Include(u => u.UserDetail)
                          .ThenInclude(ud => ud.Addresses)
                          .SingleOrDefault(u => u.UserID == userId);
        }

        public User AuthenticateUser(string username, string password)
        {
            return _context.Users
                          .Include(u => u.UserDetail)
                          .ThenInclude(ud => ud.Addresses)
                          .SingleOrDefault(u => u.UserName == username && u.Password == password);
        }

        public List<ToDoItem> GetToDoItemsForUser(int userId)
        {
            return _context.ToDoItems
                .Where(td => td.UserID == userId)
                .ToList();
        }

        public void UpdateUser(User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));

            var existingUser = _context.Users.Include(u => u.UserDetail).ThenInclude(ud => ud.Addresses).SingleOrDefault(u => u.UserID == user.UserID);

            if (existingUser != null)
            {
                existingUser.UserName = user.UserName;
                existingUser.Password = user.Password;
                existingUser.Email = user.Email;
                existingUser.Phone = user.Phone;
                existingUser.GenderID = user.GenderID;

                existingUser.UserDetail.FirstName = user.UserDetail.FirstName;
                existingUser.UserDetail.LastName = user.UserDetail.LastName;
                existingUser.UserDetail.BirthDate = user.UserDetail.BirthDate;

                var existingAddress = existingUser.UserDetail.Addresses.FirstOrDefault();
                if (existingAddress != null)
                {
                    existingAddress.Country = user.UserDetail.Addresses.First().Country;
                    existingAddress.City = user.UserDetail.Addresses.First().City;
                    existingAddress.PostalCode = user.UserDetail.Addresses.First().PostalCode;
                }

                _context.SaveChanges();
            }
        }
    }
}
