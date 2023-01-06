CREATE TABLE Customers (
  Id INTEGER PRIMARY KEY,
  Name TEXT NOT NULL,
  City TEXT NOT NULL,
  Country TEXT NOT NULL
);

INSERT INTO Customers (Id, Name, City, Country)
VALUES (1, 'Alice', 'London', 'UK');
INSERT INTO Customers (Id, Name, City, Country)
VALUES (2, 'Bob', 'New York', 'USA');
INSERT INTO Customers (Id, Name, City, Country)
VALUES (3, 'Eve', 'Paris', 'France');
INSERT INTO Customers (Id, Name, City, Country)
VALUES (4, 'Frank', 'Berlin', 'Germany');
INSERT INTO Customers (Id, Name, City, Country)
VALUES (5, 'Grace', 'Mumbai', 'India');
