# Modular Monolith .NET App

## Overview

Welcome to the Modular Monolith .NET App! 🚀 This project demonstrates a scalable and maintainable architecture for .NET applications, emphasizing clean code practices and modular design.

## Project Structure

The application is structured into modules, each comprising three fundamental components:

1. **Module.ModuleName**
   - Core business logic resides here, defining the module's unique functionalities.

2. **Module.ModuleName.Core**
   - This layer encapsulates the essential operations and functionalities specific to each module.

3. **Module.ModuleName.Infrastructure**
   - The persistence layer, managing databases, migrations, and ensuring data integrity.

For shared functionalities, the following layers are introduced:

1. **Shared.Module**
   - Hub for shared functionalities across modules, ensuring consistency.

2. **Shared.Core**
   - Houses common methods and classes, promoting code reusability.

3. **Shared.Infrastructure**
   - Handles common persistence requirements efficiently.

The Presentation.API dynamically collects controllers' APIs from modules, providing a unified and user-friendly API surface for the entire application.

## Future Work

### Data Updating Between Modules

The next exciting step is enhancing inter-module communication by implementing data updating between modules. This will elevate the application's capabilities and strengthen its overall functionality.

## Database Architecture

The application uses a single database with different schemas for each module. This approach optimizes data management and separation while maintaining a cohesive data structure for the entire application.

## Getting Started

1. Clone the repository.
2. Build the solution using your preferred IDE or the command line.
3. Update the database using migrations.

```bash
dotnet ef database update
```

4. Run the application.

```bash
dotnet run --project Presentation.API
```

## Contributing

Contributions are welcome! Feel free to open issues, submit pull requests, or provide feedback. Let's build something great together! 🚀

## License

This project is licensed under the [MIT License](LICENSE.md). Feel free to use, modify, and distribute the code as needed.

---

🌐 Happy coding! 🚀
