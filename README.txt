-- Create Users Table
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(255) NOT NULL
);

-- Create Expenses Table
CREATE TABLE Expenses (
    ExpenseID INT PRIMARY KEY IDENTITY,
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    ExpenseType NVARCHAR(50),
    Label NVARCHAR(255),
    Amount DECIMAL(18, 2),
    ExpenseDate DATE
);
