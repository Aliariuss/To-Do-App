namespace ToDoApp.Domain
{
    public class UserDetail
    {
        public int UserDetailID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
