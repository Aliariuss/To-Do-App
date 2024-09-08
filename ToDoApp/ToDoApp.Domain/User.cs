namespace ToDoApp.Domain
{
    public class User
    {
        public int UserID { get; set; }
        public UserDetail UserDetail { get; set; }
        public int GenderID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }

        public ICollection<ToDoItem> ToDoItems { get; set; }
    }
}
