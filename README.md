# Contacts Solution — WinForms

A desktop **Contact Management System** built with **C# Windows Forms**, **SQL Server**, and a **Three-Tier Architecture**. The application provides a practical CRUD workflow for managing contacts, countries, personal information, and profile images.

## Project Status

**Core functionality is implemented and working.** The project is a practical desktop application focused on database-driven CRUD operations and layered application design.

## Feature Status

### Implemented — Working

- **Contact listing** — Displays contacts in the main DataGridView.
- **Add contacts** — Creates and stores new contact records.
- **Update contacts** — Loads an existing contact and updates its information.
- **Delete contacts** — Removes selected contacts from the database.
- **Find contact by ID** — Retrieves contact information from the database.
- **Country selection** — Loads countries from the database into the form.
- **Country management logic** — Business/Data Access layers include country CRUD and lookup operations.
- **Profile images** — Selects, stores, and displays contact profile images.
- **Personal information** — Supports first name, last name, phone, email, address, date of birth, and country.
- **SQL Server persistence** — Contact and country data are stored through ADO.NET.
- **Three-Tier Architecture** — Presentation, Business Logic, and Data Access layers are separated.

### Partially Implemented / Needs Refinement

- **Input validation** — Basic application flow exists, but validation and user-friendly error handling can be expanded.
- **Image management** — Image selection and storage are implemented, but image lifecycle handling can be improved.
- **Configuration** — Database connection configuration can be made more portable for different machines.

### Planned — Coming Soon

The following features are **not currently implemented** and are planned for future updates:

- Advanced contact search and filtering.
- Sorting and pagination for large contact lists.
- Improved validation and error messages.
- More complete country-management screens.
- Configurable database connection settings.
- Better image cleanup and file management.
- UI/UX refinements.
- Automated testing.

## Architecture

```text
Presentation Layer
        │
        ▼
Business Logic Layer
        │
        ▼
Data Access Layer
        │
        ▼
SQL Server
```

## Technologies

- **C#**
- **Windows Forms**
- **.NET Framework**
- **SQL Server**
- **ADO.NET**
- **Visual Studio**
- **Three-Tier Architecture**

## Main Components

- `FrmMain.cs` — Main contact list and contact actions.
- `FrmAddEdit.cs` — Add and update contact information.
- `BusinessLogic/clsBusinessLogic.cs` — Application/business logic.
- `DataAccess/clsDataAccess.cs` — Database operations.
- `ProfileImages/` — Sample profile images.

## Getting Started

1. Clone the repository.
2. Open the solution in **Visual Studio**.
3. Configure the SQL Server connection string for your local database.
4. Make sure the required database tables are available.
5. Build the solution.
6. Run the application.

## Learning Objectives

This project demonstrates practical understanding of:

- CRUD operations.
- ADO.NET and SQL Server integration.
- Object-oriented programming.
- Three-tier architecture.
- Separation of concerns.
- Windows Forms event-driven programming.
- File/image handling.
- Database-driven desktop application development.

## Roadmap

The project will continue to be improved with stronger validation, better configuration, richer search/filtering, UI refinements, and additional management features.

## Author

**Aseelcoding**
