# ContactManager
Diese App wird von drei Entwicklern im Rahmen eines Semesterprojekts an der ZbW entwickelt.</br>
Als Architektur wird Clean Code verwendet.</br>
Die folgenden Schichten beinhalten:</br>
- **Kern:** Domain Driven Design 
- **Application:** Use Cases entstehen aus User Stories 
- **Presentation:** Windows Forms als UI
- **Infrastructure:** Holt die Daten lokal.

---
## Gruppenmitglieder 
Eduard Anderegg ( Plannung / Development )</br>
Nadine Untersee ( UI/UX Development )</br>
Joël Rohner ( Unit Testing / Testing )</br>

---
## Aufbau

### Clean Architecture
![Clean Architecture Diagram](docs/assets/Clean%20Architecture.png)

### The Core Design (DDD) als Diagram
![Domain Driven Design Diagram](docs/assets/Domain%20Driven%20Design.png)

### User Stories (ohne Login / Auth) für Use Cases
| **ID**| **User Story**                                                                                                                  | **Priorität**| **Rolle (zukünftig)** |      **Kategorie**   |
| ----- | ------------------------------------------------------------------------------------------------------------------------------- | --------- | ----------------- | --------------------------- |
| CM-01 | Als Benutzer möchte ich eine Liste aller Kontakte anzeigen, damit ich die verfügbaren Personen durchsuchen kann.                | Hoch      | Alle              | Auflistung/Suche            |
| CM-02 | Als Benutzer möchte ich Kontakte nach Rolle (Mitarbeiter, Lernende, Kunden) filtern, um die Ansicht einzugrenzen.               | Mittel    | Alle              | Auflistung/Suche            |
| CM-03 | Als Benutzer möchte ich Kontakte nach Name, Firma oder ID suchen, um Personen schnell zu finden.                                | Hoch      | Alle              | Auflistung/Suche            |
| CM-04 | Als Benutzer möchte ich ein neues Mitarbeiterprofil erstellen, um Personal dem System hinzuzufügen.                             | Hoch      | Admin             | Erstellung                  |
| CM-05 | Als Benutzer möchte ich eine/n neue/n Lernende/n erfassen, damit diese/r in unseren Kontaktdaten enthalten ist.                 | Mittel    | Admin             | Erstellung                  |
| CM-06 | Als Benutzer möchte ich einen neuen Kundenkontakt hinzufügen, um externe Beziehungen zu pflegen.                                | Mittel    | Admin             | Erstellung                  |
| CM-07 | Als Benutzer möchte ich Kontaktdaten (E-Mail, Telefon, Adresse) bearbeiten können, damit die Daten aktuell bleiben.             | Hoch      | Admin             | Bearbeitung                 |
| CM-08 | Als Benutzer möchte ich die Firma eines Kontakts zuweisen oder ändern, damit die Zugehörigkeit korrekt ist.                     | Mittel    | Admin             | Bearbeitung                 |
| CM-09 | Als Benutzer möchte ich einen Kontakt deaktivieren können, damit dieser nicht mehr in der aktiven Liste erscheint.              | Hoch      | Admin             | Deaktivierung               |
| CM-10 | Als Benutzer möchte ich deaktivierte Kontakte einsehen, um nachvollziehen zu können, wer das Unternehmen verlassen hat.         | Mittel    | Alle              | Deaktivierung               |
| CM-11 | Als Benutzer möchte ich, dass das System eindeutige Mitarbeiter-/Kundennummern generiert, damit die Nachverfolgung einfach ist. | Hoch      | System            | ID/Konsistenz               |
| CM-12 | Als Benutzer möchte ich Notizen oder Interaktionen mit Kontakten erfassen, damit die Kundenhistorie nachvollziehbar ist.        | Niedrig   | Admin             | Protokoll/Notizen           |
| CM-13 | Als Benutzer möchte ich die Protokollhistorie eines Kontakts einsehen, um kürzliche Interaktionen nachzuvollziehen.             | Niedrig   | Alle              | Protokoll/Notizen           |
| CM-14 | Als Benutzer möchte ich die Gesamtzahl an Mitarbeitenden, Lernenden und Kunden sehen, um einen schnellen Überblick zu erhalten. | Niedrig   | Alle              | Reporting                   |
| CM-15 | Als Benutzer möchte ich Kontaktdaten als CSV exportieren können, um sie extern weiterzugeben oder zu analysieren.               | Niedrig   | Admin             | Export/Nützliche Funktionen |



---
## Development

Vor dem Pushen des Codes im Repo ist Refactoring des Codes erforderlich.
```csharp
dotnet format ./ContactManager.sln
```

### Snippets
Das Projekt hat einen Snippet-Ordner. Darunter sind Snippets zu finden, die für `Visual Studio`
installiert werden können.

#### Integration
1. In Visual Studio unter: `Tools` => `Code Snippets Manager...`
2. `C#` Auswählen
3. `Import` clicken
4. `.snippet` file auswählen
5. Ein Ordner auswählen, wie `My Code Snippets` => `Bestätigen`
#### Anwenden
In einem `C# file`</br>
- Kürzel eintippen. Als beispiel: `svo`
- `Tab`  => Name der Klasse eingeben => nochmal `Tab` drücken; Typ eingeben

