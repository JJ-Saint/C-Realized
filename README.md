# CSostenido - Sports Complex Reservation System

A console application built with C# and .NET 9 that manages users, sports spaces, and reservations for a sports complex.

---

## Technologies Used

- C# with .NET 9
- Entity Framework Core 9
- Pomelo.EntityFrameworkCore.MySql 9.0.0
- MySQL (via DBeaver)
- LINQ
- MailKit (email notifications)

---

## Prerequisites

Before running this project, make sure you have the following installed:

- .NET 9 SDK
- MySQL Server
- dotnet-ef tool

To install the dotnet-ef tool:

```
dotnet tool install --global dotnet-ef --version 9.0.0
```

---

## Database Setup

1. Open MySQL and create a database called `assessment`:

```sql
CREATE DATABASE assessment;
```

2. Create a user and grant permissions:

```sql
CREATE USER 'your_user'@'localhost' IDENTIFIED BY 'your_password';
GRANT ALL PRIVILEGES ON assessment.* TO 'your_user'@'localhost';
FLUSH PRIVILEGES;
```

---

## Configuration

Open the file `Data/AppDbContext.cs` and update the connection string with your MySQL credentials:

```csharp
"server=localhost;port=3306;database=assessment;user=YOUR_USER;password=YOUR_PASSWORD;"
```

---

## Running the Project

1. Clone the repository or extract the ZIP file.

2. Navigate to the project folder:

```
cd CSostenido
```

3. Restore dependencies:

```
dotnet restore
```

4. Configure the PATH for dotnet-ef (Linux/Mac):

```
export DOTNET_ROOT=$HOME/.dotnet
export PATH="$PATH:$HOME/.dotnet:$HOME/.dotnet/tools"
```

5. Run the database migrations:

```
dotnet ef database update
```

6. Build the project:

```
dotnet build
```

7. Run the application:

```
dotnet run
```

---

## Features

### User Management
- Register new users with name, document ID, phone number, and email
- Edit existing user information
- Validate that no duplicate document ID or email exists
- List all registered users

### Sports Section Management
- Register sports spaces with name, type, and capacity
- Edit sports space information
- Validate that no duplicate spaces exist
- List and filter spaces by type

### Reservation Management
- Create reservations linked to a user and a sports space
- Validate that no overlapping reservations exist for the same space
- Validate that a user cannot have two reservations in the same time range
- Validate that end time is greater than start time
- Validate that reservations cannot be created in the past
- Cancel reservations
- Finalize reservations
- List reservations by user
- List reservations by sports space

### Email Notifications
- Sends a confirmation email when a reservation is created

---

## Project Structure

```
CSostenido/
    Data/
        AppDbContext.cs
    Helpers/
        EmailHelper.cs
    Models/
        User.cs
        SportSection.cs
        Reserve.cs
    Services/
        UserService.cs
        SportSectionService.cs
        ReserveService.cs
    Migrations/
    Program.cs
```

---

## Error Handling

All operations are wrapped in try-catch blocks. Clear error messages are displayed to the user when validations fail, such as duplicate documents, overlapping reservations, or invalid time ranges.

---

## Author

Saint - Universidad de Antioquia
Gerencia en Sistemas de Informacion en Salud