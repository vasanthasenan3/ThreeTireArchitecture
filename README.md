# Three-Tier Architecture

This repository contains my basic practice of Three-Tier Architecture in .NET. It demonstrates how an application can be organized into separate layers to improve code organization and maintainability.

## 📂 Project Structure

```text
Three-Tier-Architecture/
│
├── PresentationLayer/
├── BusinessLogicLayer/
├── DataAccessLayer/
├── Models/
└── README.md
```

## 📚 Layers Explained

### 1. Presentation Layer (PL)

* Handles the user interface.
* Accepts user input and displays output.
* Communicates with the Business Logic Layer.

### 2. Business Logic Layer (BLL)

* Contains the application's business logic.
* Handles business rules and validations.
* Connects the Presentation Layer with the Data Access Layer.

### 3. Data Access Layer (DAL)

* Handles database operations.
* Executes database queries and manages data retrieval and modification.
* Communicates with the database.

### 4. Models

* Contains classes used to represent application data.
* Defines properties to store and transfer data between layers.

## 🎯 Purpose

The purpose of this repository is to understand the basic concepts of Three-Tier Architecture and learn how to separate user interface, business logic, and database operations in .NET applications.

## 🛠️ Technologies

* C#
* .NET
* SQL Server

---

**Status:** Basic Practice 🚀
