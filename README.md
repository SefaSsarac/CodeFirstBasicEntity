# Code First Basic: Code First Approach to Creating a Database
This project demonstrates how to use the Code First approach in Entity Framework Core to create a database. 
We will create two independent tables: Movie and Game, with appropriate properties and configurations.

## Project Overview
In this project, the goal is to define model classes for Movie and Game, and use Entity Framework Core to automatically generate the database schema. Key steps include setting up properties, primary keys, and constraints like data types and value ranges.

## Table Definitions
### Movie Table
Id: Integer, Primary Key, Auto-incremented
Title: String, Movie title
Genre: String, Genre of the movie (e.g., "Action", "Comedy", "Drama")
ReleaseYear: Integer, Year of release

### Game Table
Id: Integer, Primary Key, Auto-incremented
Name: String, Name of the game
Platform: String, Platform the game is played on (e.g., "PC", "PlayStation", "Xbox")
Rating: Decimal, Rating of the game, ranging between 0 and 10

### Setup Instructions
Define the model classes for both the Movie and Game entities.
Create a DbContext class to manage the connection and provide access to the tables.
Use migrations to create and update the database schema based on the model definitions.
Run database migrations to generate the database schema automatically from the model classes.

## How to Run
Set up the project by restoring necessary packages and dependencies.
Generate the initial migration by running the migration command.
Apply the migration to create the database using the update command.
Use the created database for data operations (CRUD) via Entity Framework Core.

## Technologies Used
  C# for the application code
  
  Entity Framework Core for ORM and database interactions  
  
  SQL Server (or another RDBMS) for the database
  
 .NET Core/ASP.NET Core as the application framework
