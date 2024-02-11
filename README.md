Project 3: Library Management System

Overview

Project 3 is a Library Management System developed as a Windows Forms application in C# with Visual Studio 2022. It aims to streamline operations in libraries, facilitating book management, user role management, and the borrowing process for faculty and students.

## Features

- Login System: Secure authentication system for different roles including Admins, Faculty, and Students.
- Role Management: Enables Admins to manage user roles within the system.
- Book Managemen*: Allows Librarians to add new titles, manage book copies, and organize author information.
- Borrowing System: Faculty and Students can search for, check out, and return books.
- Return System: Simplifies the process for users to return borrowed books.

Getting Started
This section guides you through getting a copy of the project up and running on your local machine for development and testing purposes. Follow these steps to set up your environment.

Prerequisites
Before you begin, ensure you have the following software installed on your computer:

Microsoft Visual Studio 2022: The project is developed using Visual Studio 2022. If you don't have it, download and install it from Visual Studio Official Site.

.NET Framework 4.7.2 or later: The project targets .NET Framework 4.7.2. Make sure your Visual Studio installation includes support for this framework.

SQL Server (Express or higher): The project uses SQL Server for its database. SQL Server Express is a free edition and sufficient for development purposes. Download it from SQL Server Express Edition.

Setup
Clone the repository: 
First, clone the project repository to your local machine using Git. Open a terminal or command prompt and run the following command:

bash: git clone https://github.com/CJGivenchy/Project-3.git
This command downloads the project files to a folder named Project-3 in your current directory.

Open the Solution in Visual Studio:

Navigate to the cloned repository folder.
Double-click on the solution file (Project-3.sln) to open the project in Visual Studio 2022.
Restore NuGet Packages: To ensure all dependencies are correctly installed, go to the Solution Explorer in Visual Studio, right-click on the solution, and select "Restore NuGet Packages".

Database Setup:

Locate the SQL script files within the DatabaseScripts folder in your project directory. These scripts are used to create your database schema and seed initial data.
Open SQL Server Management Studio (SSMS) and connect to your SQL Server instance.
Execute the SQL scripts in the following order: first, run the schema creation script, followed by any data seeding scripts.

Update the Connection String:

Open the App.config file located in the root of the project.
Find the <connectionStrings> section and replace the placeholder connection string with your actual SQL Server connection details.
Build the Solution: Press Ctrl + Shift + B in Visual Studio or go to the "Build" menu and select "Build Solution" to compile the project.

Run the Application: Press F5 to start debugging, or Ctrl + F5 to start without debugging. This will launch the application's main window.

Next Steps
After setting up the project, explore the functionalities provided by the application, such as logging in as different user roles, adding books, and checking out or returning books.

Prerequisites

- Microsoft Visual Studio 2022
- .NET Framework 4.7.2 or compatible versions
- SQL Server (Express edition or higher)


