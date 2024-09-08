namespace ToDoApp.Domain
{
    public class Gender
    {
        public int GenderID { get; set; }
        public string GenderName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
