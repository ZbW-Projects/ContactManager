# ContactManager
Diese App wird von drei Entwicklern im Rahmen eines Semesterprojekts an der ZbW entwickelt.</br>
Als Architektur wird Clean Code verwendet.</br>
Die folgenden Schichten beinhalten:</br>
- **Kern:** Domain Driven Design 
- **Presentation:** Windows Forms als UI
- **Infrastructure:** Holt die Daten lokal.


---
## Aufbau

## Clean Architecture
![Clean Architecture Diagram](docs/assets/Clean%20Architecture.png)

## The Core Design (DDD) as a Diagram
![Domain Driven Design Diagram](docs/assets/Domain%20Driven%20Design.png)

---
## Development

Vor dem Pushen des Codes im Repo ist eine Refactoring des Codes erforderlich.
```csharp
dotnet format ./ContactManager.sln
```

### Snippets
Das Projekt hat einen Snippet-Ordner. Darunter sind Snippets zu finden, die f�r `Visual Studio`
installiert werden k�nnen.

#### Integration
1. In Visual Studio unter: `Tools` => `Code Snippets Manager...`
2. `C#` Ausw�hlen
3. `Import` clicken
4. `.snippet` file ausw�hlen
5. Ein Ordner ausw�hlen, wie `My Code Snippets` => `Best�tigen`
#### Anwenden
In einem `C# file`</br>
- K�rzel eintippen. Als beispiel: `svo`
- `Tab` => nochmal `Tab` dr�cken

