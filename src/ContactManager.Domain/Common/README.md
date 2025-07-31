# Common (SeedWork) Ordner

#### Beschreibung:
In diesem Ordner befinden sich Basisklassen, Interfaces und Enumerator, die für zentrale Domänenkonzepte verwendet werden.

Diese Klassen definieren das grundlegende Verhalten für verschiedene Bausteine innerhalb der Domain, wie z. B.:
- `Entity`
- `ValueObject`

#### Beispiel:
Wenn eine Klasse von `ValueObject` erbt, wird sie automatisch als **Value Object im Sinne von Domain-Driven Design** behandelt. 
Das bedeutet, dass ihre Gleichheit nicht über die Identität (`Id`), sondern über ihre Werte bestimmt wird. 
Das entsprechende Verhalten (z. B. `Equals`, `GetHashCode`) wird durch die Basisklasse definiert.


#### Quelle:
[Entity, IRepository](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/seedwork-domain-model-base-classes-interfaces)
[Value Objects](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/implement-value-objects)
[Enumeration Class](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types)