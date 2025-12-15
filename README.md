### Generic Repository Sample – Domain Setup

This stage sets up a clean, independent Domain layer with a generic entity contract (IEntity<TKey>).
Entities like Employee implement the contract with type-safe IDs.
Domain has no dependencies on repositories or infrastructure.
This prepares the project for future Generic Repository implementation.
Foundation ensures constraints and type safety before writing any repository code.