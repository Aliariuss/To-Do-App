namespace ToDoApp.Domain
{
    public class Address
    {
        public int AddressID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
        public int UserDetailID { get; set; }
        public UserDetail UserDetail { get; set; }
    }
}
