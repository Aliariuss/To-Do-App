# ToDoApp

**ToDoApp** is a simple task management application that allows users to register, log in, create to-do items, and track their progress.

## Features

- User registration and authentication
- Create, update, delete, and list to-do items
- Mark to-do items as completed or not completed
- Filter to-do items by status
- Drag and drop tasks between pending and completed lists
- User profile management
- Store multiple addresses for users
- Separation of concerns using layers (UI, BAL, DAL, Domain)

## Technologies Used

- **C#**: Core programming language for the application.
- **Windows Forms**: Used for the user interface.
- **Entity Framework Core**: Object-relational mapper (ORM) for database access.
- **SQL Server**: Database management system used for storing user data, tasks, and more.
- **Repository Pattern**: Applied for better management of data access.
- **Dependency Injection**: Ensures loosely coupled classes and services.

## Getting Started

### Prerequisites

To run this project, you will need:

- Visual Studio 2019 or later
- .NET Core SDK (3.1 or later)
- SQL Server (local or remote instance)
- Git (optional for cloning the repository)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/ToDoApp.git
   ```

2. Open the project in Visual Studio.

3. Restore NuGet packages:

   ```bash
   dotnet restore
   ```

4. Update the connection string in `AppDbContext` (located in `ToDoApp.DAL`):

   ```csharp
   optionsBuilder.UseSqlServer("Data Source=YourServer;Initial Catalog=ToDoAppDb;User ID=YourUserID;Password=YourPassword;TrustServerCertificate=true");
   ```

5. Apply migrations and update the database:

   ```bash
   dotnet ef database update
   ```

6. Build and run the project by pressing **F5** in Visual Studio.

### Usage

- **Login/Registration**: Start by creating a user account. You can use the "Register" form to create a new account.
- **Create To-Do Items**: After logging in, you can create new to-do items by entering a title, description, and due date.
- **Mark as Completed**: Drag and drop items from the "Pending" list to the "Completed" list.
- **Profile Management**: Update your profile details from the profile page.

### Example Data

The database is seeded with the following default data:

- Default user: 
  - Username: `Default`
  - Password: `Default`
  - Email: `Default@example.com`
  
- Available genders: `Kadın` and `Erkek`.

### Directory Structure

```plaintext
ToDoApp/
│
├── ToDoApp.Domain/          # Domain models (User, ToDoItem, UserDetail, etc.)
├── ToDoApp.DAL/             # Data access layer (EF Core mappings, AppDbContext)
├── ToDoApp.BAL/             # Business logic layer (services for user and to-do items)
├── ToDoApp.UI/              # User interface (Windows Forms)
├── ToDoApp.sln              # Solution file
└── README.md                # Project documentation
