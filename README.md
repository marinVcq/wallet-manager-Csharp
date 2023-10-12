# Expense Manager Application
## Project Dev 2 - BREST OPEN CAMPUS LEARN IT B2

This C# application is a student project developed during the second year of studies. It serves as an Expense Manager, empowering users to efficiently track and manage their expenses. The application features a user-friendly interface for adding, modifying, and deleting expenses, along with graphical representations of expense data through charts and graphs.

## Table of Contents
- [Introduction](#introduction)
- [User Story](#user-story)
- [Overview](#overview)
	- [ScreenShot](#screenshot)
	- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Usage](#usage)
- [Documentation](#documentation)
	- [Configure Database](#configure-database)
- [License](#license)

## Introduction

This Expense Manager application addresses the common challenge individuals face in efficiently managing and monitoring their expenses. The primary problems it aims to solve and the associated benefits include:
### Problem:
- **Lack of Expense Tracking**
Many individuals struggle to keep a detailed record of their expenses, leading to difficulties in budgeting, 
understanding spending patterns, and making informed financial decisions.

### Solution:
- **Efficient Expense Management**
An Expense Manager provides a centralized platform for users to log their expenses systematically. 
This includes categorizing expenses by type, adding labels, specifying amounts, and recording dates. 
By doing so, users can easily track and understand their spending habits over time.

## User Story


**Name:** View Current Expenses 
**Objectives:** View and modify current expenses online 
**Actors:**
-   **Primary:** Users
-   **Secondary:** Database Precondition: Functional website, authentication

**Main Scenario:**

1.  The system displays a login page.
2.  The user authenticates.
3.  The system redirects the user to a new page containing a list of all recorded current expenses.
4.  The user adds expenses.
5.  The system records the new expenses.
6.  The user searches for a type of expense.
7.  The system displays the corresponding expense.
8.  The user graphically views their current expenses.
9.  The system displays a chart showing the distribution of each expense relative to the total.

**Alternative Scenario #1:** 
- 2.a The user authenticates incorrectly. 
- 2.b The system signals the error and allows the user to try again. 2.c Return to step 1.

**Alternative Scenario #2:**
- 6.a The user makes a search that yields no results. 
- 6.b The system indicates that no expense matches the query. 6.c Return to step 6.

## Overview
### ScreenShot
- **Login Page**

![Login Page screenshot](https://i.imgur.com/sUBTVey.png)

- **Dashboard**

![Dashboard Screenshot](https://i.imgur.com/SmuDfYz.png)

- **Graph**

![Graph](https://i.imgur.com/Kc1qoeh.png)

- **Modify Pop-up**

![Modify pop-up](https://i.imgur.com/42Qelm8.png)

### Features
This Expense Manager application comes equipped with several features designed to enhance the user experience and streamline expense management:

#### 1. Expense Overview

- View a detailed list of expenses, including key information such as Expense Type, Label, Amount, Expense Date, and Register Date.

#### 2. Interactive Graphs

- Visualize expense data dynamically through graphs, including a line graph illustrating current expenses over time and a pie chart categorizing expenses by type.

#### 3. Filtering Capability

- Easily filter expenses by type to focus on specific categories.

#### 4. Expense Operations

- Add and modify expenses seamlessly through an intuitive user interface.
- Safely delete expenses with confirmation prompts to prevent accidental removal.

#### 5. Financial Awareness

- Enables users to gain a clear understanding of their financial habits.
- Provides insights into areas where expenses can be optimized.

#### 6. Budgeting Assistance

- Facilitates the creation of a realistic budget based on historical spending data.
- Helps users set and adhere to financial goals.

#### 7. User-Friendly Interface

- Offers an intuitive interface for adding, modifying, and deleting expenses.
- Reduces the complexity associated with financial record-keeping.

#### 8. Data Filtering

- Allows users to filter expenses by type, streamlining the analysis of specific spending categories.

#### 9. Time Efficiency

- Saves time compared to manual methods of expense tracking.
- Provides quick access to graphical representations for a rapid overview.

#### 10. Secure Operations

- Implements confirmation prompts to prevent accidental deletion of expense records.
- Ensures the integrity and security of financial data.

#### 11. Educational Value

- As a student project, it serves as an educational tool for learning C# programming, database integration, and graphical data visualization.

In summary, the Expense Manager application is feature-rich, providing users with powerful tools to effectively manage their expenses and make informed financial decisions.

## Getting Started

### Prerequisites

- [.NET Framework](https://dotnet.microsoft.com/en-us/)
- [Visual Studio](https://visualstudio.microsoft.com/fr/)
- [Microsoft SQL Server](https://www.microsoft.com/fr-fr/sql-server/sql-server-downloads)

### Installation
1.  Clone the repository to your local machine.
2.  Open the project in your preferred C# development environment (e.g., Visual Studio).
3.  Run the SQL Script 'création_script.sql' on SQL Server & Configure database in the solution.
4.  Build and run the application.

### Usage
1.  Log in with correct credentials upon launching the application.
2.  Navigate to the "Dashboard" tab to explore expense graphs and charts.
3.  Use the "Add" button to input new expenses, providing necessary details.
4.  Click the "Modify" button in the DataGridView to update existing expenses.
5.  Delete expenses securely by clicking the "Delete" button in the DataGridView.

## Documentation

### Configure Database

The application establishes a connection to a SQL Server database, you have to set your own database connection string in the AppConfig.xml file.

1- **Find the name of your server on SQL Server Management**

![enter image description here](https://i.imgur.com/8UBOYXv.png)

2- **Connect server in solution** (view -> server Explorer)

***Click on "connect to database"***

![enter image description here](https://i.imgur.com/8yNqUO7.png)

3- **Fill with your server name and select the expensesManager database**

![enter image description here](https://i.imgur.com/NTk7giy.png)

4- **Click OK**
## **Important :** **Don't forget to set the connection string in 'AppConfig.xml'**

### Database Schema
The database schema includes a table named `Expenses` with columns for `ExpenseID`, `ExpenseType`, `Label`, `Amount`, `ExpenseDate`, `RegisterDate`, and `UserID`.

### OxyPlot Integration

Using OxyPlot as an alternative to the deprecated DataVisualization namespace in .NET. The DataVisualization namespace, which includes the Chart controls, has been deprecated in recent versions of .NET. OxyPlot is a popular open-source plotting library that you can use as an alternative to create charts and plots in your .NET applications.

    Install-Package OxyPlot.WindowsForms

## License
This project is licensed under the [MIT License](https://chat.openai.com/c/LICENSE).