# Introduction

Welcome to the ToCode, a revolutionary way to streamline your web API development in C# ASP.net core, seamlessly integrated with MS SQL. This tool is designed to automate the scaffolding of your project, focusing on the essential components that drive the heart of modern web applications: data handling and business logic.

## Features

### DataModel
Our tool simplifies the complexity of database operations with an intuitive DataModel system. It includes:

- **Entities:** Define your database tables and their properties directly in your project, representing the real-world entities you're working with.
- **Relationships:** Easily configure the relationships between your entities to reflect your database's schema accurately.
- **Queries:** Access read operations efficiently through stored procedures in your MS SQL database. Our tool exposes these as functions within `IEntityService`, making data retrieval seamless.
- **Transactions:** Implement write, delete and update operations with ease. Like Queries, Transactions use stored procedures and are exposed as functions in `IEntityService`, ensuring data integrity and simplifying complex data manipulation.

### CodeModel
Beyond data, the CodeModel aspect of our tool focuses on the application logic and structure:

- **Enums:** Define and manage enums that represent the various constants and fixed values used across your DataModel and business logic.
- **Objects:** Craft custom objects that serve the unique needs of your application, from supporting DataModel operations to enriching your business logic.
- **BusinessUnits:** Leverage the power of Business Units to organize and implement your application's core functionalities. By utilizing the Crud operations of defined entities, Queries, and Transactions defined in your DataModel, you can build robust, efficient managers that drive your application's operations.

## Getting Started

Setting up your project with the ToCode is a breeze. Just provide the necessary inputs related to your DataModel and CodeModel, and let our tool do the rest. From generating entity relationships and handling database operations to setting up your business logic units, you're only a few steps away from a fully functional web API connected to MS SQL.

Enjoy the journey of building your next web application with enhanced efficiency and a focus on what truly matters: delivering value through your software. Welcome aboard!

Check our documentation at: https://to-code.com
