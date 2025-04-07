
# Unit of Work Pattern - Implementations in C#, Java, and Python

## 📌 What is the Unit of Work Pattern?

The **Unit of Work** design pattern aims to coordinate the writing of changes to multiple business objects by grouping them into a single transaction. This ensures data consistency and simplifies the management of complex operations.

## ✅ Key Principles

- **Atomicity**: All operations are executed as a single unit.
- **Centralized transaction management**.
- **Reduction of database calls**: Commit is performed only once.

## ⚖️ Advantages

- Ensures data coherence and consistency.
- Facilitates unit testing and separation of concerns.
- Improves performance by reducing unnecessary database access.

## ❌ Disadvantages

- Adds complexity to small projects.
- Requires a learning curve to fully understand its implementation.

---

## 🌐 Implementations by Language

### 1. C# with Entity Framework

```csharp
public interface IUnitOfWork : IDisposable {
    IUserRepository Users { get; }
    int Complete();
}
```

See: [`unit_of_work_csharp.cs`](./unit_of_work_csharp.cs)

---

### 2. Java with Hibernate

```java
public class UnitOfWork implements AutoCloseable {
    private Session session;
    private Transaction transaction;
    ...
}
```

See: [`unit_of_work_java.java`](./unit_of_work_java.java)

---

### 3. Python with SQLAlchemy

```python
@contextmanager
def unit_of_work(Session):
    session = Session()
    ...
```

See: [`unit_of_work_python.py`](./unit_of_work_python.py)

---

## 📚 References

- Martin Fowler - Patterns of Enterprise Application Architecture: https://martinfowler.com/eaaCatalog/unitOfWork.html
- Microsoft Docs: https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
- SQLAlchemy Docs: https://docs.sqlalchemy.org/en/latest/orm/session_basics.html
- Baeldung (Java): https://www.baeldung.com/java-transactions

