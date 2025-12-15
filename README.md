### Step 1 - Generic Repository Sample – Domain Setup

This stage sets up a clean, independent Domain layer with a generic entity contract (IEntity<TKey>).
Entities like Employee implement the contract with type-safe IDs.
Domain has no dependencies on repositories or infrastructure.
This prepares the project for future Generic Repository implementation.
Foundation ensures constraints and type safety before writing any repository code.

### Step 2 – Non-Generic Repositories

In this stage, we implemented **separate repositories** for Employee and Product entities:

- `EmployeeRepository` and `ProductRepository` store entities in memory.
- Add and GetAll methods work correctly.
- Demonstrates **code repetition** and lack of scalability.
- Sets the stage for creating a **Generic Repository** in the next step.

### Step 3 – Generic Repository

- Implemented a **Generic Repository** to replace separate Employee and Product repositories.
- `IRepository<T, TKey>` interface defines Add and GetAll methods with a **constraint**: `T : IEntity<TKey>`.
- `GenericRepository<T, TKey>` stores entities in-memory and works with **any Entity type**.
- Eliminates code repetition and enforces **type-safety** for all entities.
- Ready for adding new entities without writing additional repository classes.

### Step 4 – Covariance & Contravariance in Generic Repository

- Separated **reading** and **writing** operations using two interfaces:  
  - `IReadOnlyRepository<out T>` (Covariant) for reading entities  
  - `IWriteRepository<in T>` (Contravariant) for adding entities
- `GenericRepository<T, TKey>` implements both interfaces, storing entities in-memory.
- **Type-safety ensured**:  
  - Reading can use base types (Covariance)  
  - Writing accepts only the specific entity type (Contravariance)
- Demonstrated with `Employee` repository: adding and retrieving multiple employees using the same repository instance.

Built with .NET 10 – December 2025

