# Student Portal

This repository contains a sample Student Portal application designed to demonstrate the use of the .NET MVC framework with C# to implement backend CRUD (Create, Read, Update, Delete) operations. The primary goal of this project is to serve as a learning resource for developers who are new to the .NET MVC framework and want to understand how to build and manage CRUD operations effectively.

## Features

- **Add Student**: Allows users to add a new student to the portal.
- **Update Student**: Enables users to update existing student details.
- **Edit Student**: Provides the functionality to edit student information.
- **Delete Student**: Allows users to delete a student from the portal.

## Prerequisites

Before running this application, ensure you have the following installed:

- [Visual Studio](https://visualstudio.microsoft.com/) or any compatible .NET IDE
- [.NET SDK](https://dotnet.microsoft.com/download) (version 5.0 or later)
- SQL Server or any other compatible database

## Getting Started

1. **Clone the repository:**

    ```bash
    git clone https://github.com/your-username/StudentPortal.git
    ```

2. **Navigate to the project directory:**

    ```bash
    cd StudentPortal
    ```

3. **Restore the required packages:**

    ```bash
    dotnet restore
    ```

4. **Update the database connection string:**

   Open `appsettings.json` and update the connection string to match your database configuration.

    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Your-Database-Connection-String"
    }
    ```

5. **Apply database migrations:**

    ```bash
    dotnet ef database update
    ```

6. **Run the application:**

    ```bash
    dotnet run
    ```

7. **Open your browser and navigate to:**

    ```url
    http://localhost:5000
    ```

## Project Structure

- **Controllers**: Contains the MVC controllers that handle user input and interactions.
- **Models**: Contains the data models representing the entities in the application.
- **Views**: Contains the Razor views that render the HTML UI.
- **Data**: Contains the database context and migrations for Entity Framework Core.

## Entity Framework

Entity Framework (EF) is an open-source object-relational mapper (ORM) for .NET applications. It enables developers to work with a database using .NET objects, eliminating the need for most of the data-access code that typically needs to be written.

### Key Concepts Learned:

- **DbContext**: The primary class responsible for interacting with the database. It allows querying and saving data.
- **DbSet<TEntity>**: Represents a collection of entities that can be queried from the database.
- **Migrations**: A way to keep the database schema in sync with the data models. EF migrations are used to create and update the database schema.
- **LINQ**: Language Integrated Query (LINQ) is used to write queries against the DbSet properties.

### Example Usage:

```csharp
public class ApplicationDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}
