# **Code-Dokumentation: Interaktives Dashboard**

## **Inhaltsverzeichnis**
1. [Run Projekt](#run-project)
2. [Projekteigenschaften](#projektkonfiguration)
3. [Projektstrukturen](#projektstrukturen)
4. [Datenbankverbindung](#database-connection)
    - [SQL Skript ausführen](#run-sql-scripts)
	- [Server-Name für Connection String auslesen](#get-connection-string)
    - [Connection String in appsettings.json einfügen](#set-connection-string)

---


## 1. **How to run this project** <a name="run-project"></a>  

1. Repository Klonen 
   ```bash
   https://github.com/espas-bi-it/api-dashboard.git
   ```

2. [ApiDashboardDB Datenbank verbinden](#database-connection)

3. Projekt starten mit folgendem Command (oder direkt in Visual Studio)
   ```bash
   dotnet run --launch-profile https
   ```
 
## 2. **Projekteigenschaften** <a name="projektkonfiguration"></a>  

Die Solution **APIDashboard** besteht aus folgenden **eigenständige Projekten**.


-  ### **ApiDashboard-Projekt**:
	- **ASP.NET Core Web API**
	- **Framework**: .NET 8.0 (langfristiger Support)
	- **Authentifizierung**: Kein Authentifizierungstyp konfiguriert
	- **HTTPS**: Für HTTPS konfiguriert
	- **OpenAPI-Unterstützung**: Aktiviert
	- **Controller**: Verwendung von Controllern zur Handhabung von API-Anfragen
	- **Backend**: Läuft auf `http://localhost:5000`

-	### **Frontend-Projekt**:
	- **ASP.NET MVC UI**
	- **Framework**: .NET 8.0 (langfristiger Support)
	- **Authentifizierung**: Kein Authentifizierungstyp konfiguriert
	- **HTTPS**: Für HTTPS konfiguriert
	- **Blazor**: Server render mode
	- **Extensions**: [Syncfusion](https://ej2.syncfusion.com/aspnetmvc/documentation/introduction?_gl=1*101euba*_gcl_au*MTE5Njg5MTMwNS4xNzMwNjM3NDg4*_ga*Nzk0MTc2NTk1LjE3MzA1OTM0NTM.*_ga_41J4HFMX1J*MTczMTA5NDE1NC4xMy4wLjE3MzEwOTQxNTQuMC4wLjA. "Optionaler Linktitel") Web Template Studio mit [Bootstrap 5](https://getbootstrap.com/docs/5.0/getting-started/introduction/ "Bootstrap 5")
	-  **Frontend**: Läuft auf `http://localhost:5001`

-	### **DataAccess-Projekt**:
	- Class-Libray

-	### **Database-Projekt**:
	- SQL-Server Projekt


## 3. **Projektstrukturen** <a name="projektstrukturen"></a>  

 ### **ApiDashboard:** :arrow_down:

```plaintext
/api-dashboard
│
├── /ApiDashboard			-> Backend (ASP.NET Core)
│   ├── /Controllers			-> API-Controller
│   │    └── UserController		-> Beispiel-Controller
│   ├── /Properties			-> Projekteigenschaften
│   │    └── launchSettings.json	-> Konfiguriert Startoptionen für die Entwicklung
│   ├── ApiDasboad.csproj		-> Projektdatei für das Backend
│   ├── ApiDasboard-csproj.user		-> Weitere Projektdatei
│   ├── appsettings.Development.json	-> Entwicklungs-Konfiguration
│   ├── appsettings.json		-> Allgemeine Konfiguration
│   └── Program.cs			-> Einstiegspunkt der Anwendung 
│   └── ApiDashboard.sln 		-> Visual Studio-Lösung

```

### **Frontend:** :arrow_down:

```plaintext
/api-dashboard
│
├── /Frontend				-> Frontend (ASP.NET MVC UI)
│   ├── /Components			
│   │    └── Layout			-> Ordner für HTML-Struktur und Stylesheets
│   │    └── Pages			
│   │        └── Dashboard.razor	-> Dashboard-View (/dashboard)
│   │        └── Index.razor		-> Syncfusion Beispiel Komponenten
│   │    └── _Imports.razor		-> Zentrale Anweisungen/Direktiven für alle Razor-Komponenten
│   │    └── App.razor			-> Definiert Routing und Layout der Anwendung
│   │    └── Routes.razor		-> Definiert das Routing zu Razor-Komponenten
│   ├── /Data				-> Enthält Klassen und Dienste für Datenzugriff und -verwaltung
│   ├── /Properties			-> Projekteigenschaften
│   │    └── launchSettings.json	-> Konfiguriert Startoptionen für die Entwicklung
│   ├── /wwwroot			-> Enthält statische Dateien für die Anwendung
│   ├── appsettings.Development.json	-> Entwicklungs-Konfiguration
│   ├── appsettings.json		-> Allgemeine Konfiguration
│   ├── Frontend.csproj			-> Projektdatei für das Frontend
│   ├── Frontend.csproj.user		-> Weitere Projektdatei
│   └── Program.cs			-> Einstiegspunkt der Anwendung

```

#### Syncfusion

Die Erweiterung **Syncfusion** ist installiert.

 <img src="https://bi-it-ws.github.io/doc-img/syncfusion_1.jpg" width="700" />


- https://blazor.syncfusion.com/demos/
- https://blazor.syncfusion.com/documentation/
- https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples


Syncfusion Blazor Template Studio ist kostenlos verfügbar und kann für Testprojekte verwendet werden.
Du kannst es nutzen, um Blazor-Anwendungen mit den vorgefertigten Syncfusion-Komponenten zu erstellen, einschließlich der Implementierung eines Logins.
Allerdings musst du beachten, dass Syncfusion eine Lizenzierung für ihre Komponenten hat. Wenn du die NuGet-Pakete von Syncfusion verwendest, musst du einen Lizenzschlüssel registrieren, auch wenn du die Testversion nutzt. Für Testprojekte und Evaluierungen ist dies jedoch in der Regel problemlos möglich.

#### Installierte Packete:

* syncfusion.blazor.bulletchart\27.1.58
* syncfusion.blazor.buttons\27.1.58
* syncfusion.blazor.calendars\27.1.58
* syncfusion.blazor.cards\27.1.58
* syncfusion.blazor.charts\27.1.58
* syncfusion.blazor.dataform\27.1.58
* syncfusion.blazor.dropdowns\27.1.58
* syncfusion.blazor.grid\27.1.58
* syncfusion.blazor.inplaceeditor\27.1.58
* syncfusion.blazor.inputs\27.1.58
* syncfusion.blazor.kanban\27.1.58
* syncfusion.blazor.layouts\27.1.58
* syncfusion.blazor.lists\27.1.58
* syncfusion.blazor.navigations\27.1.58
* syncfusion.blazor.notifications\27.1.58
* syncfusion.blazor.pdfviewer\27.1.58
* syncfusion.blazor.pdfviewerserver.windows\27.1.58
* syncfusion.blazor.popups\27.1.58
* syncfusion.blazor.progressbar\27.1.58
* syncfusion.blazor.querybuilder\27.1.58
* syncfusion.blazor.richtexteditor\27.1.58
* syncfusion.blazor.spinner\27.1.58
* syncfusion.blazor.splitbuttons\27.1.58
* syncfusion.blazor.stockchart\27.1.58
* syncfusion.blazor.themes\27.1.58
* syncfusion.blazor.treegrid\27.1.58
* syncfusion.pdf.net.core\27.1.58

Man kann weitere NuGet Packete hinzufügen.

### **DataAccess:** :arrow_down:

```plaintext
/api-dashboard
│
├── /DataAccess				-> Backend (Class Library)
│   ├── /Data				-> Enthält Interfaces für den Datenzugriff und die Datenverwaltung
│   ├── /DBAccess			-> Führt Datenbankoperationen mit Dapper aus, lädt und speichert Daten über gespeicherte Prozeduren
│   ├── /Models				-> Ordner für Models - Definiert eine Datenstruktur mit spezifischen Eigenschaften
│   ├── /Services			-> Lorem Ipsum
│   ├── DataAccess.csproj		-> Projektdatei für das Backend


```

### **Database**: :arrow_down:

```plaintext
/api-dashboard
│
├── /Database	         -> Backend (SQL-Server Project)
│   ├── /Controllers     -> Lorem Ipsum
│   ├── /Properties      -> Lorem Ipsum
│   ├── Database.csproj	 -> Projektdatei für das Backend

```

## 4. **Datenbankverbindung** <a name="database-connection"></a>  


### SQL Skript ausführen: <a name="run-sql-scripts"></a>  

1.  [SQL-Server Management Studio](https://aka.ms/ssmsfullsetup) herunterladen und installieren
2. **Verbindung zur Datenbank herstellen:** Verbinde dich mit deiner SQL Server-Instanz
3. **SQL Skrpt ausführen:** In SQL-Server Management Studio" ein neues Query (New Query) erstellen und folgendes Script einfügen und anschliessend das Script mit "Execute" ausführen (grüner Pfeil):

```
CREATE DATABASE ApiDashboard;
GO

USE ApiDashboard;
GO

CREATE TABLE [dbo].[User]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE [dbo].[collaborator]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL,
    [TeamRole] NVARCHAR(50) NOT NULL
);
GO

CREATE PROCEDURE [dbo].[spUser_Delete]
    @Id INT
AS
BEGIN
    DELETE FROM dbo.[User]
    WHERE Id = @Id;
END;
GO

CREATE PROCEDURE [dbo].[spUser_Get]
    @Id INT
AS
BEGIN
    SELECT Id, FirstName, LastName
    FROM dbo.[User]
    WHERE Id = @Id;
END;
GO

CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
BEGIN
    SELECT Id, FirstName, LastName
    FROM dbo.[User];
END;
GO

CREATE PROCEDURE [dbo].[spUser_Insert]
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.[User] (FirstName, LastName)
    VALUES (@FirstName, @LastName);
END;
GO

CREATE PROCEDURE [dbo].[spUser_Update]
    @Id INT,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50)
AS
BEGIN
    UPDATE dbo.[User]
    SET FirstName = @FirstName, LastName = @LastName
    WHERE Id = @Id;
END;
GO

-- Daten in die Tabelle User einfügen
INSERT INTO [dbo].[User] (FirstName, LastName)
VALUES ('John', 'Doe'), ('Jane', 'Smith');
GO

-- Daten in die Tabelle collaborator einfügen
INSERT INTO [dbo].[collaborator] (FirstName, LastName, TeamRole)
VALUES ('Alice', 'Johnson', 'Developer'), ('Bob', 'Brown', 'Manager');
GO
```

### Server-Name für Connection String auslesen: <a name="get-connection-string"></a>  

1. **Datenbank auswählen:** Navigiere im Objekt-Explorer zu deiner Datenbank `ApiDashboard` (Falls die DB nicht sichtbar ist, refreshen)
2. **Eigenschaften öffnen:** Klicke mit der rechten Maustaste auf die `ApiDashboard` und wähle **“Properties”** aus.
3. Klicke auf "**View Connection Properties**"
4. Kopiere den Wert naben **Server-Name**


### Connection String in appsettings.json einfügen: <a name="set-connection-string"></a>  

> ℹ️ **Info:** Falls die Dateien `appsettings.Development.json` noch nicht existieren dann bitte eine in den jewiligen Stammverzeichnissen erstellen. Als Vorlage kann die bestehende `appsettings.json` genommen werden.

Unter **"Default"** den formatieren String einfügen.

Beispiel:
 ```c
"ConnectionStrings": {
     "Default": "Server=[YOUR_SERVER_NAME];Database=ApiDashboard;Trusted_Connection=True;MultipleActiveResultSets=true"
	}
```

Speichern nicht vergessen :-)


###Option 2 mit phpmyadmin

1. XAMPP herunterladen (falls noch nicht gemacht)
2. Diens im MySQL im Control panel starten
3. Zur Seite localhost/phpmyadmin navigieren
4. Unter dem Tab "SQL" folgendes Skript einfügen.

```
-- Datenbank erstellen
CREATE DATABASE ApiDashboard;

-- Datenbank verwenden
USE ApiDashboard;

-- Tabelle User erstellen
CREATE TABLE User (
    Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, 
    FirstName VARCHAR(50) NOT NULL, 
    LastName VARCHAR(50) NOT NULL
);

-- Tabelle collaborator erstellen
CREATE TABLE collaborator (
    Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, 
    FirstName VARCHAR(50) NOT NULL, 
    LastName VARCHAR(50) NOT NULL,
    TeamRole VARCHAR(50) NOT NULL
);

-- Prozedur spUser_Delete erstellen
DELIMITER //
CREATE PROCEDURE spUser_Delete(IN Id INT)
BEGIN
    DELETE FROM User WHERE Id = Id;
END //
DELIMITER ;

-- Prozedur spUser_Get erstellen
DELIMITER //
CREATE PROCEDURE spUser_Get(IN Id INT)
BEGIN
    SELECT Id, FirstName, LastName FROM User WHERE Id = Id;
END //
DELIMITER ;

-- Prozedur spUser_GetAll erstellen
DELIMITER //
CREATE PROCEDURE spUser_GetAll()
BEGIN
    SELECT Id, FirstName, LastName FROM User;
END //
DELIMITER ;

-- Prozedur spUser_Insert erstellen
DELIMITER //
CREATE PROCEDURE spUser_Insert(IN FirstName VARCHAR(50), IN LastName VARCHAR(50))
BEGIN
    INSERT INTO User (FirstName, LastName) VALUES (FirstName, LastName);
END //
DELIMITER ;

-- Prozedur spUser_Update erstellen
DELIMITER //
CREATE PROCEDURE spUser_Update(IN Id INT, IN FirstName VARCHAR(50), IN LastName VARCHAR(50))
BEGIN
    UPDATE User SET FirstName = FirstName, LastName = LastName WHERE Id = Id;
END //
DELIMITER ;

-- Daten in die Tabelle User einfügen
INSERT INTO User (FirstName, LastName) VALUES ('John', 'Doe'), ('Jane', 'Smith');

-- Daten in die Tabelle collaborator einfügen
INSERT INTO collaborator (FirstName, LastName, TeamRole) VALUES ('Alice', 'Johnson', 'Developer'), ('Bob', 'Brown', 'Manager');
```
## Connection String angpassen

Der Connection-String im appsettings.Development.json sieht so aus:

```
  "ConnectionStrings": {
    "Default": "Server=localhost;Database=ApiDashboard;User Id=root;Password=;"
  }
```
