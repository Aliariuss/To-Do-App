﻿
namespace ToDoApp.Domain
{
    public class ToDoItem
    {
        public int ToDoItemID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }
    }
}
