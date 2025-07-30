WaiteringSystem

A Windows Forms application for managing restaurant employee data, built with C# and .NET Framework 4.8.

Overview
The WaiteringSystem is a desktop application designed to manage restaurant staff information including waiters, runners, and head waiters. The application provides a user-friendly interface for adding, viewing, and managing employee records with different roles and compensation structures. Was created for course assignment.

Features
- Employee Management: Add, view, and manage restaurant employees
- Role-Based System : Support for different employee roles:
  -Head Waiter: Salary-based compensation
  - Waiter: Tips, hourly rate, and shift-based compensation
  - Runner: Tips, hourly rate, and shift-based compensation
- Database Integration : SQL Server database for persistent data storage
- MDI Interface : Multiple Document Interface for better user experience
- Employee Listing : View all employees or filter by specific roles

Architecture

The application follows a layered architecture pattern:

Presentation Layer (`Presentation/`)
- `EmployeesMDIParent.cs` - Main MDI container form
- `EmployeeForm.cs` - Form for adding/editing employee details
- `EmployeeListingForm.cs` - Form for displaying employee lists

Business Layer (`Business/`)
- `Employee.cs` - Base employee class inheriting from Person
- `EmployeeController.cs` - Controller for employee operations
- `Role.cs` - Base role class
- `HeadWaiter.cs` - Head waiter role implementation
- `Waiter.cs` - Waiter role implementation
- `Runner.cs` - Runner role implementation

Data Layer (`Data/`)
- `DB.cs` - Database connection and operations
- `EmployeeDB.cs` - Employee-specific database operations
- `Database.cs` - Database form interface

Models
- `Person.cs` - Base person class
- `EmployeeDatabaseDataSet.xsd` - Typed dataset for database operations

Prerequisites

- Visual Studio 2017 or later(or Visual Studio Code with C# extensions)
- .NET Framework 4.8
- SQL Server (LocalDB or Express edition)
- Windows OS (Windows 7 or later)

Installation and Setup

1. Clone or download the project
   ```bash
   git clone [repository-url]
   cd WaiteringSystem
   ```

2. Open the solution
   - Open `WaiteringSystem.sln` in Visual Studio
   - Or use Visual Studio Code with C# extensions

3. Database Setup
   - The project includes `EmployeeDatabase.mdf` (LocalDB database)
   - Ensure SQL Server LocalDB is installed
   - The database connection is configured in `App.config`

4. Build and Run
   - Build the solution (Ctrl+Shift+B)
   - Run the application (F5 or Ctrl+F5)
   - Preferable to use Visual Studio

Usage

Main Interface
- The application opens with an MDI (Multiple Document Interface) parent form
- Use the menu bar to access different features

Adding Employee
1. Navigate to Employee → Add New Employee
2. Fill in the employee details:
   - Personal information (name, contact details)
   - Employee ID
   - Role selection (Head Waiter, Waiter, or Runner)
   - Role-specific information (salary, tips, hourly rate, shifts)
3. Click Save to add the employee to the database

Viewing Employees
- Employee → List All Employees - View all employees
- Employee → List Head Waiters - Filter by head waiter role
- Employee → List Waiters - Filter by waiter role
- Employee → List Runners - Filter by runner role

Project Structure

```
WaiteringSystem/
├── WaiteringSystem.sln              # Solution file
└── WaiteringSystem/
    ├── Program.cs                   # Application entry point
    ├── App.config                   # Application configuration
    ├── WaiteringSystem.csproj       # Project file
    ├── Presentation/                # UI Layer
    │   ├── EmployeesMDIParent.cs    # Main MDI form
    │   ├── EmployeeForm.cs          # Employee input form
    │   └── EmployeeListingForm.cs   # Employee listing form
    ├── Business/                    # Business Logic Layer
    │   ├── Employee.cs              # Employee entity
    │   ├── EmployeeController.cs    # Employee operations
    │   ├── Role.cs                  # Base role class
    │   ├── HeadWaiter.cs            # Head waiter role
    │   ├── Waiter.cs                # Waiter role
    │   └── Runner.cs                # Runner role
    ├── Data/                        # Data Access Layer
    │   ├── DB.cs                    # Database operations
    │   └── EmployeeDB.cs            # Employee data access
    ├── EmployeeDatabase.mdf         # SQL Server LocalDB database
    └── EmployeeDatabaseDataSet.xsd  # Typed dataset
```

Technical Details

Framework
- NET Framework 4.8
- Windows Forms for UI
- SQL Server LocalDB for data storage

Design Patterns
- MVC Pattern**: Separation of concerns between Model, View, and Controller
- Layered Architecture**: Presentation, Business, and Data layers
- Inheritance**: Employee roles inherit from base Role class
- Encapsulation**: Private fields with public properties

Database Schema
The application uses a SQL Server database with tables for:
- Employee information
- Role-specific data
- Personal details




