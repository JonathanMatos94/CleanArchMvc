# Clean Architecture Study Project with C#, .NET, and MVC Principles, Repository Pattern, CQRS, DDD, Dependency Injection and Dependency Inversion (Clean Architecture Fundamentals - Prof. Macoratti)

## Description
This project is a C# solution in the .NET environment that was developed with the aim of studying and applying the main concepts of Clean Architecture, as well as integrating several other software design patterns and principles. Clean Architecture promotes the construction of well-structured and highly testable systems, ensuring separation of concerns and code maintainability.

### Main Concepts and Patterns
- **Clean Architecture**: The architecture is organized into concentric layers, with an emphasis on layer independence and separation of responsibilities. The layers are: `Domain`, `Application`, `Infra.Data`, `Infra.IoC` and `WebUI`.

- **MVC (Model-View-Controller)**: The presentation layer follows the MVC pattern, where the `Model` represents the data and business logic, the `View` is responsible for the presentation and the `Controller` handles user interaction.

- **Repository Pattern**: The `Infra.Data` layer uses the Repository pattern to abstract data access and promote the separation of persistence operations.

- **CQRS (Command Query Responsibility Segregation)**: The application adopts the CQRS principle, which separates reading operations (Query) from writing operations (Command), for optimization and scalability.

- **DDD (Domain-Driven Design)**: The project follows some DDD principles, with a clear separation of domain entities, aggregates, and application services.

- **Dependency Injection and Dependency Inversion**: Dependency inversion is implemented to allow injection of dependencies throughout the project, facilitating implementation switching and testability.

## Project Structure
The project structure follows the Clean Architecture organization:

- **Domain**: The domain layer that contains the entities, aggregates and business rules.

- **Application**: The application layer that handles use cases and contains application services.

- **Infra.Data**: The persistence layer that takes care of access to databases or other forms of data storage.
 
- **Infra.IoC**: The control inversion and dependency injection layer.

- **WebUI**: The presentation layer, where user interaction is handled.

## Requirements
- Visual Studio 2022 or higher
- .NET 7.0 or higher

## Settings
1. Clone this repository into your development environment.
2. Open the solution in Visual Studio.
3. Make sure the `Infra.Data` layer is configured correctly to connect to your database.
4. Run the `WebUI` layer project.

## Usage
The project is a simple example of a store application with categories and products, but you can add your own entities, use cases, and controllers to implement your business logic. Make sure you follow the principles of Clean Architecture, DDD, and other standards discussed in this project.

## Tests
The project includes a testing framework, using libraries such as xUnit and Moq. You can write tests to validate the functionality of your code and ensure software quality.

## Author
Jonathan de Carvalho Matos
oakmatos.jonathan@gmail.com

## License
None
