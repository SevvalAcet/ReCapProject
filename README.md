Under development..

# Rent a Car Project

* The project was developed in C#, in accordance with the multi-layered architecture and SOLID principles.
* CRUD operations were performed using the Entity Framework.
* MSSQL Localdb was used for database in the project.
* This system includes authentication and authorization.
* Users can only perform transactions for which they are authorized.
* The project includes CRUD operations for car, brand, color, car images, user, operations claim, user operation claims, customer, credit card and rental.
* Car rental is carried out according to certain business rules.

# Layers
* Core : The core layer of the project is used for universal operations.
* DataAccess : It is the layer that connects the project with the Database.
* Entities: Our tables in the database have been created as objects in our project. It also contains DTO objects.
* Business : It is the business layer of our project. Various business rules; Data controls, validations and authorization controls.
* WebAPI : It is the Restful API Layer of the project. Known methods: Get, Post, Put, Delete.

# Used Technologies
* Restful API
* Result Types
* Interceptor
* Autofac
* AOP, Aspect Oriented Programming
* Caching
* Performance
* Transaction
* Validation
* Fluent Validation
* Cache Management
* Repository Design Pattern
* Cross Cutting Concerns
* Extensions
* Claim
* Exception Middleware
* Service Collection
* Error Handling
* Validation Error Details
