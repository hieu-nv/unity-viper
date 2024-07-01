# Unity VIPER (An implementation of VIPER in Unity)

## What is VIPER?

> The VIPER design pattern is commonly used in iOS application development. It offers an alternative to other patterns like MVC or MVVM, providing a good layer of abstraction for more scalable and testable code. Here’s a breakdown of the VIPER components:

1. **View**: Represents what the user sees.
2. **Interactor**: Handles logic after receiving orders from the Presenter.
3. **Presenter**: Connects all components, receives user actions from the View, communicates with the Interactor, and manages routing using the Router.
4. **Entity**: Contains information and data used by the functionality (often backed by CoreData for storage).
5. **Router**: Controls navigation flow between screens or modules.

VIPER emphasizes single responsibility, making it a powerful choice for well-structured iOS apps.

