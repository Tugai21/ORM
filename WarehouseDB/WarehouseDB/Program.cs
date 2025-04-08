
using System.Data.Common;
using Database;
using Microsoft.Data.SqlClient;

string connectionString = "Server=DESKTOP-TTNBSCK;Database=master;Trusted_Connection=True;";

string checkCMD = "@if exists(select 1 from sys.databases where name='Warehouse') select 1 else select 0";

string createCMD = "CREATE DATABASE Warehouse";
string createCustomerCMD = "CREATE TABLE Customer (Id INT PRIMARY KEY, Name NVARCHAR(50) NOT NULL)";
string createTableCMD = "CREATE TABLE Product (Id INT PRIMARY KEY, Name NVARCHAR(50) NOT NULL, Price DECIMAL(18,2) NOT NULL)" +
    "Customer_Id int FOREIGN KEY REFERENCES Customer(Id))";

DbConnect connection = new DbConnect(connectionString, checkCMD, createCMD);