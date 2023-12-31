/****** Object:  Database [expensesManager]    Script Date: 12/10/2023 08:49:19 ******/

-- Drop database if exists
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'expensesManager') DROP DATABASE expensesManager
GO

-- Create Database expensesManager
CREATE DATABASE expensesManager
GO

-- Use it
USE expensesManager
GO

/****** Object:  Table Users Script Date: 12/10/2023 08:49:19 ******/
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(255) NOT NULL
)
GO

/****** Object:  Table Expenses   Script Date: 12/10/2023 08:49:19 ******/
CREATE TABLE Expenses (
    ExpenseID INT PRIMARY KEY IDENTITY,
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    ExpenseType NVARCHAR(50),
    Label NVARCHAR(255),
    Amount DECIMAL(18, 2),
    ExpenseDate DATE,
    RegisterDate DATETIME
)
GO

-- Insert values into Users table
INSERT INTO Users (Username, Password) VALUES ('admin', 'admin123'),('marin', 'marin123'),('jb', 'jb123'),('christian', 'christian123');

-- Insert values into Expenses table
INSERT INTO Expenses (UserID, ExpenseType, Label, Amount, ExpenseDate, RegisterDate)
VALUES
    (1, 'Groceries', 'Shopping', 50.00, '2023-10-01', '2023-10-11T12:30:00'),
    (2, 'Entertainment', 'Movie', 20.00, '2023-10-02', '2023-10-11T15:45:00'),
    (3, 'Utilities', 'Electricity', 100.00, '2023-10-03', '2023-10-11T18:15:00'),
	
	(1, 'Dining', 'Restaurant', 40.00, '2023-10-04', '2023-10-11T20:30:00'),
    (2, 'Travel', 'Flight', 200.00, '2023-10-05', '2023-10-11T22:45:00'),
    (3, 'Shopping', 'Clothing', 75.00, '2023-10-06', '2023-10-12T10:15:00'),

    (1, 'Health', 'Gym', 30.00, '2023-10-07', '2023-10-12T12:30:00'),
    (2, 'Groceries', 'Supermarket', 60.00, '2023-10-08', '2023-10-12T15:45:00'),
    (3, 'Entertainment', 'Concert', 75.00, '2023-10-09', '2023-10-12T18:15:00'),

    (1, 'Travel', 'Hotel', 120.00, '2023-10-10', '2023-10-12T20:30:00'),
    (2, 'Dining', 'Cafe', 15.00, '2023-10-11', '2023-10-12T22:45:00'),
    (3, 'Utilities', 'Water Bill', 30.00, '2023-10-12', '2023-10-13T10:15:00'),

    (1, 'Shopping', 'Electronics', 300.00, '2023-10-13', '2023-10-13T12:30:00'),
    (2, 'Health', 'Dentist', 80.00, '2023-10-14', '2023-10-13T15:45:00'),
    (3, 'Groceries', 'Fresh Market', 45.00, '2023-10-15', '2023-10-13T18:15:00'),

    (1, 'Entertainment', 'Theater', 25.00, '2023-10-16', '2023-10-14T20:30:00'),
    (2, 'Travel', 'Car Rental', 60.00, '2023-10-17', '2023-10-14T22:45:00'),
    (3, 'Dining', 'Fast Food', 10.00, '2023-10-18', '2023-10-15T10:15:00'),

    (1, 'Health', 'Medication', 40.00, '2023-10-19', '2023-10-15T12:30:00'),
    (2, 'Shopping', 'Home Decor', 90.00, '2023-10-20', '2023-10-15T15:45:00'),
    (3, 'Entertainment', 'Theme Park', 150.00, '2023-10-21', '2023-10-15T18:15:00'),

    (1, 'Utilities', 'Gas Bill', 25.00, '2023-10-22', '2023-10-16T20:30:00'),
    (2, 'Health', 'Yoga Class', 30.00, '2023-10-23', '2023-10-16T22:45:00'),
    (3, 'Dining', 'Pizza Delivery', 18.00, '2023-10-24', '2023-10-17T10:15:00'),

    (1, 'Shopping', 'Shoes', 50.00, '2023-10-25', '2023-10-17T12:30:00'),
    (2, 'Entertainment', 'Music Concert', 70.00, '2023-10-26', '2023-10-17T15:45:00'),
    (3, 'Travel', 'Uber Ride', 15.00, '2023-10-27', '2023-10-17T18:15:00'),

    (1, 'Dining', 'Sushi', 35.00, '2023-10-28', '2023-10-18T20:30:00'),
    (2, 'Health', 'Doctor Appointment', 50.00, '2023-10-29', '2023-10-18T22:45:00'),
    (3, 'Utilities', 'Internet Bill', 60.00, '2023-10-30', '2023-10-19T10:15:00'),

    (1, 'Shopping', 'Electronics', 250.00, '2023-10-31', '2023-10-19T12:30:00'),
    (2, 'Entertainment', 'Bookstore', 30.00, '2023-11-01', '2023-10-19T15:45:00'),
    (3, 'Travel', 'Train Ticket', 45.00, '2023-11-02', '2023-10-19T18:15:00'),

    (1, 'Dining', 'Italian Restaurant', 60.00, '2023-11-03', '2023-10-20T20:30:00'),
    (2, 'Health', 'Gym Membership', 50.00, '2023-11-04', '2023-10-20T22:45:00'),
    (3, 'Shopping', 'Home Appliances', 120.00, '2023-11-05', '2023-10-21T10:15:00'),

    (1, 'Entertainment', 'Movie Streaming', 15.00, '2023-11-06', '2023-10-21T12:30:00'),
    (2, 'Travel', 'Bus Fare', 5.00, '2023-11-07', '2023-10-21T15:45:00'),
    (3, 'Dining', 'Fast Food', 12.00, '2023-11-08', '2023-10-21T18:15:00'),

    (1, 'Health', 'Vitamins', 25.00, '2023-11-09', '2023-10-22T20:30:00'),
    (2, 'Shopping', 'Clothing', 80.00, '2023-11-10', '2023-10-22T22:45:00'),
    (3, 'Entertainment', 'Concert Tickets', 70.00, '2023-11-11', '2023-10-23T10:15:00'),

    (1, 'Travel', 'Airbnb', 90.00, '2023-11-12', '2023-10-23T12:30:00'),
    (2, 'Dining', 'Cafe', 18.00, '2023-11-13', '2023-10-23T15:45:00'),
    (3, 'Utilities', 'Electricity Bill', 55.00, '2023-11-14', '2023-10-23T18:15:00'),

    (1, 'Shopping', 'Tech Gadgets', 200.00, '2023-11-15', '2023-10-24T20:30:00'),
    (2, 'Health', 'Dental Checkup', 75.00, '2023-11-16', '2023-10-24T22:45:00'),
    (3, 'Groceries', 'Fresh Produce', 35.00, '2023-11-17', '2023-10-25T10:15:00'),

    (1, 'Entertainment', 'Video Games', 40.00, '2023-11-18', '2023-10-25T12:30:00'),
    (2, 'Travel', 'Taxi Fare', 25.00, '2023-11-19', '2023-10-25T15:45:00'),
    (3, 'Dining', 'Pizzeria', 30.00, '2023-11-20', '2023-10-25T18:15:00'),

	(1, 'Health', 'Pharmacy', 15.00, '2023-11-21', '2023-10-26T20:30:00'),
    (2, 'Shopping', 'Electronics', 300.00, '2023-11-22', '2023-10-26T22:45:00'),
    (3, 'Entertainment', 'Music Concert', 80.00, '2023-11-23', '2023-10-27T10:15:00'),
	
    (1, 'Travel', 'Car Maintenance', 120.00, '2023-11-24', '2023-10-27T12:30:00'),
    (2, 'Dining', 'Fast Food', 10.00, '2023-11-25', '2023-10-27T15:45:00'),
    (3, 'Utilities', 'Water Bill', 25.00, '2023-11-26', '2023-10-27T18:15:00'),

    (1, 'Shopping', 'Clothing', 50.00, '2023-11-27', '2023-10-28T20:30:00'),
    (2, 'Entertainment', 'Theater', 40.00, '2023-11-28', '2023-10-28T22:45:00'),
    (3, 'Travel', 'Flight Tickets', 200.00, '2023-11-29', '2023-10-29T10:15:00'),

    (1, 'Dining', 'Italian Restaurant', 60.00, '2023-11-30', '2023-10-29T12:30:00'),
    (2, 'Health', 'Gym Membership', 50.00, '2023-12-01', '2023-10-29T15:45:00'),
    (3, 'Shopping', 'Home Decor', 90.00, '2023-12-02', '2023-10-29T18:15:00'),

    (1, 'Entertainment', 'Theme Park', 150.00, '2023-12-03', '2023-10-30T20:30:00'),
    (2, 'Utilities', 'Gas Bill', 30.00, '2023-12-04', '2023-10-30T22:45:00'),
    (3, 'Health', 'Yoga Class', 20.00, '2023-12-05', '2023-10-31T10:15:00'),

    (1, 'Shopping', 'Shoes', 50.00, '2023-12-06', '2023-10-31T12:30:00'),
    (2, 'Entertainment', 'Concert Tickets', 70.00, '2023-12-07', '2023-10-31T15:45:00'),
    (3, 'Travel', 'Uber Ride', 15.00, '2023-12-08', '2023-10-31T18:15:00'),

    (1, 'Dining', 'Sushi', 35.00, '2023-12-09', '2023-11-01T20:30:00'),
    (2, 'Health', 'Doctor Appointment', 50.00, '2023-12-10', '2023-11-01T22:45:00'),
    (3, 'Utilities', 'Internet Bill', 60.00, '2023-12-11', '2023-11-02T10:15:00'),

    (1, 'Shopping', 'Electronics', 200.00, '2023-12-12', '2023-11-02T12:30:00'),
    (2, 'Entertainment', 'Bookstore', 30.00, '2023-12-13', '2023-11-02T15:45:00'),
    (3, 'Travel', 'Train Ticket', 45.00, '2023-12-14', '2023-11-02T18:15:00'),

    (1, 'Dining', 'Cafe', 18.00, '2023-12-15', '2023-11-03T20:30:00'),
    (2, 'Utilities', 'Electricity Bill', 55.00, '2023-12-16', '2023-11-03T22:45:00'),
    (3, 'Shopping', 'Tech Gadgets', 150.00, '2023-12-17', '2023-11-04T10:15:00'),

    (1, 'Entertainment', 'Movie Streaming', 15.00, '2023-12-18', '2023-11-04T12:30:00'),
    (2, 'Travel', 'Bus Fare', 5.00, '2023-12-19', '2023-11-04T15:45:00'),
    (3, 'Dining', 'Fast Food', 12.00, '2023-12-20', '2023-11-04T18:15:00'),

    (1, 'Health', 'Vitamins', 25.00, '2023-12-21', '2023-11-05T20:30:00'),
    (2, 'Shopping', 'Clothing', 80.00, '2023-12-22', '2023-11-05T22:45:00'),
    (3, 'Entertainment', 'Concert Tickets', 70.00, '2023-12-23', '2023-11-06T10:15:00'),

    (1, 'Travel', 'Airbnb', 90.00, '2023-12-24', '2023-11-06T12:30:00'),
    (2, 'Dining', 'Cafe', 18.00, '2023-12-25', '2023-11-06T15:45:00'),
    (3, 'Utilities', 'Water Bill', 25.00, '2023-12-26', '2023-11-06T18:15:00'),

    (1, 'Shopping', 'Clothing', 50.00, '2023-12-27', '2023-11-07T20:30:00'),
    (2, 'Entertainment', 'Theater', 40.00, '2023-12-28', '2023-11-07T22:45:00'),
    (3, 'Travel', 'Flight Tickets', 200.00, '2023-12-29', '2023-11-08T10:15:00');

