# Expense Manager Application
## Project Dev 2 - BREST OPEN CAMPUS LEARN IT B2

This C# application is a student project developed during the second year of studies. It serves as an Expense Manager, empowering users to efficiently track and manage their expenses. The application features a user-friendly interface for adding, modifying, and deleting expenses, along with graphical representations of expense data through charts and graphs.

## Table of Contents
- [Introduction](#introduction)
- [Overview](#overview)
	- [ScreenShot](#screenshot)
	- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Usage](#usage)
- [Documentation](#documentation)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgments](#acknowledgments)

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

##### 11. Educational Value

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
3.  Run SQL Script on SQL Server & Configure database access in the solution.
4.  Build and run the application.

### Usage
1.  Log in with correct credentials upon launching the application.
2.  Navigate to the "Dashboard" tab to explore expense graphs and charts.
3.  Use the "Add" button to input new expenses, providing necessary details.
4.  Click the "Modify" button in the DataGridView to update existing expenses.
5.  Delete expenses securely by clicking the "Delete" button in the DataGridView.

## Documentation

### Database Connection

The application establishes a connection to a SQL Server database, you have to set your own database connection string in the AppConfig.xml file.

### Database Schema
The database schema includes a table named `Expenses` with columns for `ExpenseID`, `ExpenseType`, `Label`, `Amount`, `ExpenseDate`, `RegisterDate`, and `UserID`.



### OxyPlot Integration

Using OxyPlot as an alternative to the deprecated DataVisualization namespace in .NET. The DataVisualization namespace, which includes the Chart controls, has been deprecated in recent versions of .NET. OxyPlot is a popular open-source plotting library that you can use as an alternative to create charts and plots in your .NET applications.

    Install-Package OxyPlot.WindowsForms