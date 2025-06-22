# Contoso University Web Application

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Technology: ASP.NET Core 7.0](https://img.shields.io/badge/ASP.NET%20Core-7.0-blue.svg)](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
[![Database: EF Core](https://img.shields.io/badge/Entity%20Framework%20Core-blueviolet.svg)](https://learn.microsoft.com/en-us/ef/core/)

## Project Description

This "Contoso University" web application is a project I am actively developing, built with **ASP.NET Core 7.0** and **Entity Framework Core**. It serves as a practical demonstration of my skills in creating robust, data-driven solutions for university administration. While still under active development, my implementation already showcases key functionalities for managing student information and user access control, reflecting best practices in modern web development.

## Screenshots

Here are some visual glimpses of the application's current state:

* **Welcome Page:**
    ![Contoso University Welcome Page](https://i.imgur.com/your-welcome-page-screenshot-link.png) * **Students List:**
    ![Contoso Students List](https://i.imgur.com/your-students-screenshot-link.png) * **User Account Management:**
    ![User Accounts Management](https://i.imgur.com/your-users-screenshot-link.png) * **Role Management:**
    ![Roles Management](https://i.imgur.com/your-roles-screenshot-link.png) * **Admin Dropdown Menu:**
    ![Admin Dropdown](https://i.imgur.com/your-admin-dropdown-screenshot-link.png) * **Student Body Statistics (Placeholder):**
    ![Student Body Statistics Page](https://i.imgur.com/your-stats-screenshot-link.png) ## Features Implemented

* **Comprehensive Student Management:**
    * Full **CRUD (Create, Read, Update, Delete)** operations for student records.
    * Paginated listing of students (first name, last name, enrollment date).
    * Robust **search functionality** to find students by name.
* **Administrative User & Role Management:**
    * Dedicated **Admin section** with secure access control.
    * **User Account Management:** View, create, edit, and delete user accounts (ID, name, email).
    * **Role-Based Access Control (RBAC):** Define and assign roles (e.g., "Admin," "Customer") to users, controlling access to features.
* **Intuitive User Interface & Navigation:**
    * Clear top navigation (Home, About, Students, Admin).
    * "Admin" dropdown for easy access to "User Management" and "Role Management."
* **Scalable Architecture:** Built on ASP.NET Core 7.0 with Entity Framework Core for robust data persistence.

## Technologies Used

* **Backend:** ASP.NET Core 7.0
* **Database:** Entity Framework Core
* **Database System:** [e.g., SQL Server, SQLite]
* **Frontend:** HTML, CSS, JavaScript
* **Version Control:** Git, GitHub

## Getting Started

### Prerequisites

* [.NET SDK 7.0 or higher](https://dotnet.microsoft.com/download/dotnet/7.0)
* A code editor (e.g., Visual Studio 2022, VS Code)
* [Your chosen database system, e.g., SQL Server LocalDB]

### Installation and Setup

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/](https://github.com/)[YOUR_GITHUB_USERNAME]/[YOUR_REPOSITORY_NAME].git
    cd [YOUR_REPOSITORY_NAME]
    ```
2.  **Configure Database Connection:**
    * Open `appsettings.json` (or `appsettings.Development.json`) and update the `ConnectionStrings` section to point to your local database instance.
        ```json
        "ConnectionStrings": {
          "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ContosoUniversity;Trusted_Connection=True;MultipleActiveResultSets=true"
        }
        ```
        *(Adjust the connection string as per your database setup.)*
3.  **Restore NuGet packages:**
    ```bash
    dotnet restore
    ```
4.  **Apply Database Migrations:**
    *(If you're using Entity Framework Core Migrations, ensure the `dotnet-ef` tool is installed: `dotnet tool install --global dotnet-ef`)*
    ```bash
    dotnet ef database update
    ```
5.  **Run the application:**
    ```bash
    dotnet run
    ```
    The application will typically launch at `https://localhost:[PORT_NUMBER]` (e.g., `https://localhost:5198`).

## Usage

* Navigate through the application using the top menu bar.
* Explore student management by clicking on "Students."
* Access administrative features like "User Management" and "Role Management" via the "Admin" dropdown.
* "Default Admin: Admin
*  Password: Secret123$

## About the "About Page"

The "About" page typically provides meta-information about the "Contoso University" web application itself. It details the project's purpose (demonstrating ASP.NET Core & EF Core), the specific technologies used in its development, and acknowledges the development credits. It serves to explain what the site is and why it exists.

## Future Development

I am actively working on extending the application's capabilities.



## Contributing

Contributions are welcome! If you have suggestions or would like to contribute:

1.  Fork the repository.
2.  Create your feature branch (`git checkout -b feature/AmazingFeature`).
3.  Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4.  Push to the branch (`git push origin feature/AmazingFeature`).
5.  Open a Pull Request.

## License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). See the `LICENSE` file for details.

## Contact

[Lukhanyo Kalashe] - [kalashslukhanyo@gmail.com] - [https://www.linkedin.com/in/lukhanyo-kalashe-55320b22a/]

## Acknowledgments


* Created by: Lukhanyo
