
# Car Rental Backend

The project was developed as part of the assignment for the Car Rental Backend Project.
And this project focuses on car rental in a functional and safe way.

##  Approaches

- **N-Tier Architecture**: The project follows the N-Tier Architecture, which divides the application into multiple layers such as presentation, business logic, and data access layers. This approach enhances modularity, scalability, and maintainability.

- **Object Oriented Programming (OOP)**: Object-oriented programming principles are utilized throughout the project. This approach promotes code reusability, encapsulation, and abstraction, making the codebase more organized and easier to maintain.

- **Aspect Oriented Programming (AOP)**: Aspect-oriented programming principles are employed to modularize cross-cutting concerns such as logging, caching, and error handling. AOP helps in separating these concerns from the core business logic, resulting in cleaner and more maintainable code.

- **Dependency Injection**: Dependency injection is used to inject dependencies into components rather than having the components create their dependencies. This approach promotes loose coupling, testability, and flexibility by allowing dependencies to be easily swapped or mocked.

- **Generic Repository Pattern**: The project implements the generic repository pattern, which provides a generic interface to perform CRUD (Create, Read, Update, Delete) operations on various entities. This pattern promotes code reuse and simplifies data access logic by abstracting away the underlying data storage mechanism.

- **JWT (JSON Web Token) Authentication**: JSON Web Tokens are used for authentication purposes. JWT authentication provides a secure way to authenticate users by generating and validating tokens, enhancing the security of the application.

- **SOLID Principles**: The SOLID principles (Single Responsibility, Open/Closed, Liskov Substitution, Interface Segregation, Dependency Inversion) are followed throughout the project. These principles promote clean architecture, maintainability, and extensibility by encouraging modular, loosely coupled, and testable code.

## Technologies

- **.NET Core**: The project is built on the .NET Core platform, which is a cross-platform, open-source framework for building modern, cloud-based applications. .NET Core provides a flexible and efficient development environment.

- **ASP.NET Core Web API**: ASP.NET Core Web API is used to develop RESTful APIs. It provides a lightweight, high-performance framework for building web services that can be consumed by various clients.

- **Autofac**: Autofac is used as the dependency injection container in the project. It provides a powerful and flexible way to manage dependencies and perform dependency injection in .NET applications.

- **FluentValidation**: FluentValidation is used for input validation in the project. It provides a fluent interface for defining validation rules and helps in ensuring the validity of input data before processing it.

- **JWT (JSON Web Token)**: JSON Web Tokens are used for authentication and authorization in the project. JWT provides a secure way to transmit information between parties as a JSON object and is commonly used for implementing stateless authentication mechanisms.

- **SQL Server**: SQL Server is used as the relational database management system (RDBMS) in the project. It provides robust data storage and management capabilities, along with support for advanced features such as transactions, indexing, and security.

## Layers
- **Business**
- **Core**
- **Data Access**
- **Entities**
- **Web API**
  
## Business Layer
![Business Layer](https://github.com/burakgunce/Car-Rental-Backend/assets/87397100/e4986684-8e2c-4594-ad9c-5cbc5e1d9f7d)

## Core Layer
![Core Layer](https://github.com/burakgunce/Car-Rental-Backend/assets/87397100/c4353d20-44a1-4fbb-9ace-ef6507cfcc79)

## Data Access Layer
![Data Access Layer](https://github.com/burakgunce/Car-Rental-Backend/assets/87397100/9fd584eb-1b63-4b45-8f75-9f4fed8e902d)

## Entities Layer
![Entities Layer](https://github.com/burakgunce/Car-Rental-Backend/assets/87397100/0461fe4c-bced-4736-8d65-68f2e26c0235)

## WebAPI Layer
![Web API Layer](https://github.com/burakgunce/Car-Rental-Backend/assets/87397100/5d421c1c-6975-40cf-9db8-0c06a21dfe4a)
