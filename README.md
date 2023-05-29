# Layered architecture

In this example, the layered architecture pattern is used to separate concerns into different layers. The Presentation Layer (UI) is responsible for interacting with the user and collecting input. The Business Logic Layer (UserService) contains the business logic and performs the authentication process. The Data Access Layer (UserRepository) is responsible for accessing and manipulating the data (in this case, a list of users). Finally, the Domain Model (User) represents the user entity.

This layered architecture allows for separation of concerns, making the code more modular, maintainable, and testable. Each layer has its own responsibilities, and communication between layers is done through well-defined interfaces or method calls.