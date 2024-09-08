using Microsoft.EntityFrameworkCore;
using ToDoApp.DAL.AppDBContext;
using ToDoApp.Domain;

namespace ToDoApp.BAL.ToDoItemServices
{
    public class ToDoItemServices
    {
        private readonly AppDbContext _context;

        public ToDoItemServices(AppDbContext context)
        {
            _context = context;
        }

        public List<ToDoItem> GetUserToDoItems(int userId)
        {
            return _context.ToDoItems.Where(t => t.UserID == userId).ToList();
        }

        public void AddToDoItems(ToDoItem item, int userId)
        {
            var user = _context.Users.Find(userId);
            if (user == null)
            {
                throw new Exception("User not found");
            }

            item.UserID = userId;
            item.IsCompleted = false;
            _context.ToDoItems.Add(item);
            _context.SaveChanges();
        }

        public void CompleteToDoItem(int toDoItemId)
        {
            var toDoItem = _context.ToDoItems.Find(toDoItemId);
            if (toDoItem != null)
            {
                toDoItem.IsCompleted = true;
                _context.SaveChanges();
            }
        }
        public void UncompleteToDoItem(int toDoItemId)
        {
            var toDoItem = _context.ToDoItems.Find(toDoItemId);
            if (toDoItem != null)
            {
                toDoItem.IsCompleted = false;
                _context.SaveChanges();
            }
        }

        public void DeleteToDoItem(int toDoItemId)
        {
            var toDoItem = _context.ToDoItems.Find(toDoItemId);
            if (toDoItem != null)
            {
                _context.ToDoItems.Remove(toDoItem);
                _context.SaveChanges();
            }
        }

        public void UpdateToDoItem(ToDoItem toDoItem)
        {
            var existingItem = _context.ToDoItems.Find(toDoItem.ToDoItemID);
            if (existingItem != null)
            {
                _context.Entry(existingItem).State = EntityState.Detached;
                _context.ToDoItems.Update(toDoItem);
                _context.SaveChanges();
            }
        }





    }
}
